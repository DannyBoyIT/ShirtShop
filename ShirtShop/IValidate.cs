using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShirtShop
{
    public interface IValidate
    {
        void CheckAvailability();
        void CheckDiscount();
        void CheckIfAdmin();
        void CheckLoggedIn();
        void CheckUserInput();
    }
}