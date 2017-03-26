using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Project.services
{
    [Table("Psd")]
    class Password
    {
        [Column("id")]
        [PrimaryKey]
        [AutoIncrement]
        public int id { get; set; }

        [Column("password")]
        public string password { get; set; }

        [Column("status")]
        public string status { get; set; }
    }
}
