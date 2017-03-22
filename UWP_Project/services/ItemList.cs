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

        public static List<Item> GetItems(String year,String month, String location)
        {
            var items = new List<Item>();
            
            using (var conn = AppDatabase.GetDbConnection())
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
            result = items;
            return items;
        }

        public static List<Item> GetItems()
        {
            return (List<Item>)result;
        }
    }
        
}
