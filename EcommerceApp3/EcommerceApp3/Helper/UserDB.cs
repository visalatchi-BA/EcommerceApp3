using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using EcommerceApp3.Interface;
using EcommerceApp3.Model;
using System.Linq;
using Xamarin.Forms;
using System.IO;

namespace EcommerceApp3.Helper
{
   public  class UserDB 
    {

        private readonly SQLiteConnection _SQLiteConnection;

        public UserDB()
        {
            var fileName = "UserDatabase.db3";
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);
            var connection = new SQLiteConnection(path);
            _SQLiteConnection = connection;
            _SQLiteConnection.CreateTable<User>();
        }
        //public IEnumerable<User> GetUsers()
        //{
        //    return (from u in _SQLiteConnection.Table<User>()
        //            select u).ToList();
        //}
        //public User GetSpecificUser(int id)
        //{
        //    return _SQLiteConnection.Table<User>().FirstOrDefault(t => t.Id == id);
        //}
        //public void DeleteUser(int id)
        //{
        //    _SQLiteConnection.Delete<User>(id);
        //}
        public string AddUser(User user)
        {
            var data = _SQLiteConnection.Table<User>();
            var d1 = data.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
            if (d1 == null)
            {
                _SQLiteConnection.Insert(user);
                return "Sucessfully Added";
            }
            else
                return "Mail id Already Exist";

        }
        //public bool UpdateUserValidation(string userid)
        //{
        //    var data = _SQLiteConnection.Table<User>();
        //    var d1 = (from values in data
        //              where values.UserName == userid
        //              select values).Single();
        //    if (d1 != null)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}
        //public bool UpdateUser(string username, string pwd)
        //{
        //    var data = _SQLiteConnection.Table<User>();
        //    var d1 = (from values in data
        //              where values.UserName == username
        //              select values).Single();
        //    if (true)
        //    {
        //        d1.Password = pwd;
        //        _SQLiteConnection.Update(d1);
        //        return true;
        //    }
        //    else
        //        return false;
        //}
        public bool LoginValidate(string userName1, string pwd1)
        {
            var data = _SQLiteConnection.Table<User>();
            var d1 = data.Where(x => x.UserName == userName1 && x.Password == pwd1).FirstOrDefault();

            if (d1 != null)
            {
                return true;
            }
            else
                return false;
        }


    }
}
