using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public sealed partial class SearchResultPage : Page
    {
        public SearchResultPage()
        {
            this.InitializeComponent();
        }

        public List<Item> items = ItemList.GetItems();

        
        //text "delete" tapped 
        private async void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //get current selected item
            Item selection = (Item)grvSelectItem.SelectedItem;
            string itemName = selection.detail;
            //indicate delete function (delete from database)
            items.Remove(selection);
            ItemList.deleteItem(itemName);
            string msg = $"Item: "+itemName+"  deleted !";
            await new MessageDialog(msg).ShowAsync();
            //reload page
            this.Frame.Navigate(typeof(SearchResultPage));
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
            this.Frame.Navigate(typeof(ChangePsdPage));
        }
    }
}
