using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace UWP_Project.services
{
    /**
     *  This is the bean class for storing item object
     *  Also for creating table of SQLite
     */


    [Table("items")]
    public class Item
    {
        [Column("id")]
        [PrimaryKey]
        [AutoIncrement]
        public int id { get; set; }

        [Column("detail")]
        public string detail { get; set; }

        [Column("operate")]
        public string operate { get; set; }

        [Column("value")]
        public double value { get; set; }

        [Column("currency")]
        public string currency { get; set; }

        [Column("location")]
        public string location { get; set; }

        [Column("date")]
        public string date { get; set; }
        



    }
}
