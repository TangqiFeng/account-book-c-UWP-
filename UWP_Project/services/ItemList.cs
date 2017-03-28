using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Project.services
{
    /**
     *  This Class handling quering items from SQLite database 
     *  with different conditions (e.g. search by year/month/location)
     *  need to look at the layout and state management
     */


    class ItemList
    {
        private static object result;//Store dynamic Searched result, for update GridView

        // Tow GetItems methods. one with parameters to renew the result. 
        //                       another with no parameter to get latest esult
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
                else
                {
                    items.Add(new Item
                    {
                        detail = "ERROR ! Please Type correct search condition!"
                    });
                }
                


            }
            result = items;
            return items;
        }

        //return latest result
        public static List<Item> GetItems()
        {
            return (List<Item>)result;
        }

        public static void deleteItem(String detail)
        {
            using (var conn = AppDatabase.GetDbConnection())
            {
                conn.Execute("DELETE FROM items Where detail = ?", detail);
                
            }
        }

    }
        
}
