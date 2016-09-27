using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShirtShop
{
    public class User : IUser
    {
        private bool _isAdmin;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }  
        public string City { get; set; }      
        public string Telephone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsAdmin
        {
            get { return false; }
            set { _isAdmin = value; }
        }

        public void LogIn() { }

        public void LogOut() { }
    }
}