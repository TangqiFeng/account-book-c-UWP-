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
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            using (var conn = AppDatabase.GetDbConnection())
            {
                conn.CreateTable<Password>();
                var addPsd = new Password() { password = "0000", status = "" };
                var count = conn.Insert(addPsd);
                var status = conn.Table<Password>().Where(v => v.id.Equals(1));
                foreach (var item in status)
                {
                    if(item.status == "Logined")
                    {
                        spInputPassword.Visibility = Visibility.Collapsed;
                        spButtons.Visibility = Visibility.Visible;
                        spFoot.Visibility = Visibility.Visible;
                    }
                }
                conn.Execute("UPDATE Psd SET status = ? Where Id = ?", "no", 1);
                //delete invalid password (because once the page opened a new password record created)
                var check = conn.Table<Password>().Where(v => v.id > 1);
                foreach (var item in check)
                {
                    if (item.status == "")
                    {
                        conn.Execute("DELETE FROM Psd Where Id = ?", item.id);
                    }
                }
            }
        }

        #region Home Page

        private void btnToHomePage_Click(object sender, RoutedEventArgs e)
        {
            spInputPassword.Visibility = Visibility.Collapsed;
            spButtons.Visibility = Visibility.Visible;
            spFoot.Visibility = Visibility.Visible;
        }

        private void btnToSetPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ChangePsdPage));
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
        
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var conn = AppDatabase.GetDbConnection())
            {
                var password = conn.Table<Password>().Where(v => v.id.Equals(1));
                foreach (var item in password)
                {
                    if (txtPassword.Text != null)
                    {
                        if (txtPassword.Text == item.password)
                        {
                            spInputPassword.Visibility = Visibility.Collapsed;
                            spButtons.Visibility = Visibility.Visible;
                            spFoot.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            string msg = $"Please Input valid Password!";
                            await new MessageDialog(msg).ShowAsync();
                        }
                    }
                    else
                    {
                        string msg = $"Please Input Password!";
                        await new MessageDialog(msg).ShowAsync();
                    }
                }

            }
        }
    }

}
