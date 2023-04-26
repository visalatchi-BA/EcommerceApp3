using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using EcommerceApp3.Interface;
using SQLite;
using System.IO;

namespace EcommerceApp3.Droid
{
    public class ISQLiteDBInterface_Andriod : ISQLiteInterface
    {
        public SQLiteConnection GetSQLiteConnection()
        {
            var fileName = "UserDatabase.db3";
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}