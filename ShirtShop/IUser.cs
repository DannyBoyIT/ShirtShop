using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShirtShop
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string Telephone { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        

        void LogIn();
        void LogOut();
    }
}