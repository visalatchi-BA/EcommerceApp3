using System;
using System.Collections.Generic;
using System.Text;
using EcommerceApp3.Model;
using SQLite;

namespace EcommerceApp3.Interface
{
    public  interface ISQLiteInterface
    {
        SQLiteConnection GetSQLiteConnection();
        

    }
}
