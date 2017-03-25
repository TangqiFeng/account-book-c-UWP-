using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace UWP_Project.services
{
    /**
     * This class is connecting to SQLite database
     * 
     */


    class AppDatabase
    {
        public readonly static string DbPath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "test.db");

        public static SQLiteConnection GetDbConnection()
        {
            // connect to SQLite, create a new database when the database is not exist.
            var conn = new SQLiteConnection(new SQLitePlatformWinRT(), DbPath);
            // create table
            conn.CreateTable<Item>();
            return conn;
        }
    }
}
