﻿using System;
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
            
            
        }

        private void btnToAddPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddItemPage));
        }

        private void btnToSearchPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SearchItemPage));
        }

        #endregion
        


    }

}
