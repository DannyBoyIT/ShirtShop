using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShirtShop
{
    public interface IUser
    {
        string Address { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MobileNumber { get; set; }
        string Password { get; set; }
        string Username { get; set; }

        void LogIn();
        void LogOut();
    }
}