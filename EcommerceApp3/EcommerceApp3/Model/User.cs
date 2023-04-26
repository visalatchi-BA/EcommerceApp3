using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EcommerceApp3.Model
{
    public class User
    {
       // [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
       // [MaxLength(12)]
        public string Password { get; set; }
       // [MaxLength(10)]
        public string PhoneNumber  { get; set; }

        
    }
}
