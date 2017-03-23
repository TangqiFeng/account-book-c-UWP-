using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Project.services
{
    class ItemList
    {
        private static object result;

        public static List<Item> GetItems(string year, string month, string location, string searchType)
        {
            // binding the SearchHistory page's gridview
            var items = new List<Item>();
            
            //query result from SQLite
            using (var conn = AppDatabase.GetDbConnection())
            {
                if(searchType == "year")
                {
                    var query = conn.Table<Item>().Where(v => v.date.EndsWith(year));
                    foreach (var item in query)
                    {
                        items.Add(new Item
                        {
                            id = item.id,
                            detail = item.detail,
                            operate = item.operate,
                            value = item.value,
                            location = item.location,
                            currency = item.currency,
                            date = item.date
                        });
                    }
                }
                else if (searchType == "month")
                {
                    string date = month + "/" + year;
                    var query = conn.Table<Item>().Where(v => v.date.EndsWith(date));
                    foreach (var item in query)
                    {
                        items.Add(new Item
                        {
                            id = item.id,
                            detail = item.detail,
                            operate = item.operate,
                            value = item.value,
                            location = item.location,
                            currency = item.currency,
                            date = item.date
                        });
                    }
                }
                else if (searchType == "location")
                {
                    var query = conn.Table<Item>().Where(v => v.location.Contains(location));
                    foreach (var item in query)
                    {
                        items.Add(new Item
                        {
                            id = item.id,
                            detail = item.detail,
                            operate = item.operate,
                            value = item.value,
                            location = item.location,
                            currency = item.currency,
                            date = item.date
                        });
                    }
                }


            }
            result = items;
            return items;
        }

        public static List<Item> GetItems()
        {
            return (List<Item>)result;
        }
    }
        
}
