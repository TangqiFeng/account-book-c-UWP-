using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_Project.services;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class SearchItemPage : Page
    {
        public SearchItemPage()
        {
            this.InitializeComponent();
        }

        private void btnToHomePage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        #region search Page

        #region Choose search type (by year/month/location)
        //Three search conditions handler

        public string SearchType = "";
        private void radSearchByMonth_Checked(object sender, RoutedEventArgs e)
        {
            spChooseByYear.Visibility = Visibility.Visible;
            spChooseByMonth.Visibility = Visibility.Visible;
            spChooseByLocation.Visibility = Visibility.Collapsed;
            SearchType = "month";
        }

        private void radSearchByYear_Checked(object sender, RoutedEventArgs e)
        {
            spChooseByYear.Visibility = Visibility.Visible;
            spChooseByMonth.Visibility = Visibility.Collapsed;
            spChooseByLocation.Visibility = Visibility.Collapsed;
            SearchType = "year";
        }

        private void radSearchByLocation_Checked(object sender, RoutedEventArgs e)
        {
            spChooseByYear.Visibility = Visibility.Collapsed;
            spChooseByMonth.Visibility = Visibility.Collapsed;
            spChooseByLocation.Visibility = Visibility.Visible;
            SearchType = "location";
        }

        #endregion

        private void btnSearchReset_Click(object sender, RoutedEventArgs e)
        {
            txtSearchYear.Text = "";
            txtSearchMonth.Text = "";
            txtSearchLocation.Text = "";
        }

        List<Item> items;// store the dynamic quering result for binding data of GridView
        private void btnSearchSubmit_Click(object sender, RoutedEventArgs e)
        {
            this.InitializeComponent();
            if (spSearch.Visibility == Visibility.Visible)
            {
                spSearch.Visibility = Visibility.Collapsed;
            }


            String year = txtSearchYear.Text;
            String month = txtSearchMonth.Text;
            String location = txtSearchLocation.Text;
            items = ItemList.GetItems(year, month, location, SearchType);
            this.Frame.Navigate(typeof(SearchResultPage));
        }
        #endregion
    }

}
