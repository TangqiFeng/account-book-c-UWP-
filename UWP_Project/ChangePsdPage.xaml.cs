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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChangePsdPage : Page
    {
        public ChangePsdPage()
        {
            this.InitializeComponent();
        }

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
            this.Frame.Navigate(typeof(SearchItemPage));
        }


        private async void btnChangePsd_Click(object sender, RoutedEventArgs e)
        {
            //if nothing typed
            if (txtOldPsd.Password == "" || txtNewPsd.Password == "")
            {
                string msg = $"Please Input old/new Password!";
                await new MessageDialog(msg).ShowAsync();
            }
            else
            {
                //check old password
                //Change password
                string oldPsd = txtOldPsd.Password;
                string newPsd = txtNewPsd.Password;
                using (var conn = AppDatabase.GetDbConnection())
                {
                    var psd = conn.Table<Password>().Where(v => v.id.Equals(1));
                    foreach (var item in psd)
                    {
                        if(oldPsd == item.password)
                        {
                            conn.Execute("UPDATE Psd SET password = ? Where Id = ?", newPsd, 1);
                            string msg = $"Password changed!";
                            await new MessageDialog(msg).ShowAsync();

                            //back to home page
                            this.Frame.Navigate(typeof(MainPage));
                        }
                        else // Invalid old Password
                        {
                            string msg = $"Invalid old Password!";
                            await new MessageDialog(msg).ShowAsync();
                        }
                    }
                }
            }

        }
    }
}
