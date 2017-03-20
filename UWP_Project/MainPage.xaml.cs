using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_Project.services;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }

        #region Home Page

        private void btnToHomePage_Click(object sender, RoutedEventArgs e)
        {
            if (spSearch.Visibility == Visibility.Visible)
            {
                spSearch.Visibility = Visibility.Collapsed;
            }
            if (spAdd.Visibility == Visibility.Visible)
            {
                spAdd.Visibility = Visibility.Collapsed;
            }
            if (spMain.Visibility == Visibility.Collapsed)
            {
                spMain.Visibility = Visibility.Visible;
            }
        }

        private void btnToAddPage_Click(object sender, RoutedEventArgs e)
        {
            spMain.Visibility = Visibility.Collapsed;
            spAdd.Visibility = Visibility.Visible;
        }

        private void btnToSearchPage_Click(object sender, RoutedEventArgs e)
        {
            spMain.Visibility = Visibility.Collapsed;
            spSearch.Visibility = Visibility.Visible;
        }

        #endregion

        #region add item Page

        string opt;

        #region Choose income / expenditure
        private void radMinus_Checked(object sender, RoutedEventArgs e)
        {
            opt = radMinus.Tag.ToString();
        }

        private void radPlus_Checked(object sender, RoutedEventArgs e)
        {
            opt = radPlus.Tag.ToString();
        }

        #endregion
        
        private void btnGetLocation_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void btnAddSubmit_Click(object sender, RoutedEventArgs e)
        {
            string des = txtDescribe.Text;
            double value = Convert.ToDouble(txtValue.Text);
            string date = arrivalCalendarDatePicker.Date.ToString();
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

        private void btnAddReset_Click(object sender, RoutedEventArgs e)
        {
            txtDescribe.Text = "";
            txtLocation.Text = "";
            txtValue.Text = "";
        }

        #endregion

        #region search Page

        #region Choose search type (by year/month/location)

        private void radSearchByMonth_Checked(object sender, RoutedEventArgs e)
        {
            spChooseByYear.Visibility = Visibility.Visible;
            spChooseByMonth.Visibility = Visibility.Visible;
            spChooseByLocation.Visibility = Visibility.Collapsed;
        }

        private void radSearchByYear_Checked(object sender, RoutedEventArgs e)
        {
            spChooseByYear.Visibility = Visibility.Visible;
            spChooseByMonth.Visibility = Visibility.Collapsed;
            spChooseByLocation.Visibility = Visibility.Collapsed;
        }

        private void radSearchByLocation_Checked(object sender, RoutedEventArgs e)
        {
            spChooseByYear.Visibility = Visibility.Collapsed;
            spChooseByMonth.Visibility = Visibility.Collapsed;
            spChooseByLocation.Visibility = Visibility.Visible;
        }

        #endregion

        private void btnSearchReset_Click(object sender, RoutedEventArgs e)
        {
            txtSearchYear.Text = "";
            txtSearchMonth.Text = "";
            txtSearchLocation.Text = "";
        }




        #endregion

        
    }

}
