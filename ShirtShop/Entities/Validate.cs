using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShirtShop
{
    public static class Validate
    {
        public static void CheckAvailability()
        {
         
        }

        public static void CheckDiscount()
        {
         
        }

        public static void CheckIfAdmin()
        {
           
        }

        public static bool CheckLoggedIn(User getRegistration)
        {
            return true;
        }

        public static bool CheckUserInput(User getRegistration)
        {
            bool inputOk = true;
            if (string.IsNullOrWhiteSpace(getRegistration.FirstName))
            {
                MessageBox.Show("Förnamnet saknas!");
                inputOk = false;
            }
            if (string.IsNullOrWhiteSpace(getRegistration.LastName))
            {
                MessageBox.Show("Efternamnet saknas!");
                inputOk = false;
            }
            if (string.IsNullOrWhiteSpace(getRegistration.Email))
            {
                MessageBox.Show("Emailet saknas!");
                inputOk = false;
            }
            if (string.IsNullOrWhiteSpace(getRegistration.Address))
            {
                MessageBox.Show("Adressen saknas!!");
                inputOk = false;
            }
            if (string.IsNullOrWhiteSpace(getRegistration.City))
            {
                MessageBox.Show("Staden saknas!");
                inputOk = false;
            }
            if (string.IsNullOrWhiteSpace(getRegistration.Username))
            {
                MessageBox.Show("Användarnamnet saknas!");
                inputOk = false;
            }
            if (string.IsNullOrWhiteSpace(getRegistration.Password))
            {
                MessageBox.Show("Lösenordet saknas");
                inputOk = false;
            }

            return inputOk;
        }
    }
}