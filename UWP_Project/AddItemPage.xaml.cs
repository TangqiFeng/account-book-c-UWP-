using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_Project.services;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Services.Maps;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddItemPage : Page
    {
        public AddItemPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        #region MainPage_Loaded (get currentlocation)
        Geolocator myGeo;
        Geoposition _pos;
        String CurrentLocation = "Loading... try again later!";
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            initialiseGeoLocation();
        }

        private async void initialiseGeoLocation()
        {
            var access = await Geolocator.RequestAccessAsync();
            switch (access)
            {
                case GeolocationAccessStatus.Allowed:
                    // set some stuff up now.
                    myGeo = new Geolocator();
                    //myGeo.PositionChanged not needed just now.
                    myGeo.DesiredAccuracy = PositionAccuracy.High;
                    //Save position to currentLocation
                    GetCurrentLocation();
                    break;
                case GeolocationAccessStatus.Denied:
                case GeolocationAccessStatus.Unspecified:
                    // ask the user for something here if things go wrong.
                    string msg = $"Can't access location services";
                    await new MessageDialog(msg).ShowAsync();
                    break;
                default:
                    break;
            }
        }

        private async void GetCurrentLocation()
        {
            try
            {
                _pos = await myGeo.GetGeopositionAsync();
            }
            catch (Exception ex)
            {
                string msg = $"Problem reading location" + ex.Message;
                await new MessageDialog(msg).ShowAsync();
                return;
            }
            BasicGeoposition myLocation = new BasicGeoposition
            {
                Longitude = _pos.Coordinate.Point.Position.Longitude,
                Latitude = _pos.Coordinate.Point.Position.Latitude
            };
            Geopoint pointToReverseGeocode = new Geopoint(myLocation);
            MapLocationFinderResult result = await MapLocationFinder.FindLocationsAtAsync(pointToReverseGeocode);
            CurrentLocation = result.Locations[0].Address.Town.ToString()
                               + ", " + result.Locations[0].Address.Country.ToString();
        }

        #endregion
        private void btnToHomePage_Click(object sender, RoutedEventArgs e)
        {
            using (var conn = AppDatabase.GetDbConnection())
            {
                conn.Execute("UPDATE Psd SET status = ? Where Id = ?", "Logined", 1);
                
            }
            this.Frame.Navigate(typeof(MainPage));
        }

        private void btnToSetPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ChangePsdPage));
        }

        #region add item Page


        #region Choose income / expenditure

        string opt;
        private void radMinus_Checked(object sender, RoutedEventArgs e)
        {
            opt = radMinus.Tag.ToString();
        }

        private void radPlus_Checked(object sender, RoutedEventArgs e)
        {
            opt = radPlus.Tag.ToString();
        }

        #endregion

        private async void btnGetLocation_Click(object sender, RoutedEventArgs e)
        {
            txtLocation.Text = CurrentLocation;
        }

        private async void btnAddSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescribe.Text) || string.IsNullOrWhiteSpace(txtValue.Text)
               || string.IsNullOrWhiteSpace(txtLocation.Text) || string.IsNullOrWhiteSpace(calendarDatePicker.Date.ToString()))
            {
                string msg = $"Please Input Item Correctly!";
                await new MessageDialog(msg).ShowAsync();
            }
            else
            {
                string des = txtDescribe.Text;
                double value = Convert.ToDouble(txtValue.Text);
                string date = calendarDatePicker.Date.Value.Day.ToString() + "/" +
                              calendarDatePicker.Date.Value.Month.ToString() + "/" +
                              calendarDatePicker.Date.Value.Year.ToString();
                string loc = txtLocation.Text;
                string currency = ((ComboBoxItem)cmbChooseCurrency.SelectedItem).Tag.ToString();

                using (var conn = AppDatabase.GetDbConnection())
                {
                    var addPerson = new Item() { detail = des, operate = opt, value = value, location = loc, date = date, currency = currency };

                    var count = conn.Insert(addPerson);

                    string msg = $"new item is NO. {addPerson.id}, {addPerson.detail}";
                    await new MessageDialog(msg).ShowAsync();
                }
            }
            txtDescribe.Text = "";
            txtLocation.Text = "";
            txtValue.Text = "";

        }

        private void btnAddReset_Click(object sender, RoutedEventArgs e)
        {
            txtDescribe.Text = "";
            txtLocation.Text = "";
            txtValue.Text = "";
        }

        #endregion

        
    }
}
