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

        public static int CheckLoggedIn(User getRegistration)
        {


            return 0;
        }

        public static bool CheckUserInput(User getRegistration)
        {
            bool inputOk = true;
            if (string.IsNullOrWhiteSpace(getRegistration.FirstName))
            {
                MessageBox.Show("Fel förnamn!");
                inputOk = false;
            }
            if (string.IsNullOrWhiteSpace(getRegistration.LastName))
            {
                MessageBox.Show("Fel efternamn!");
                inputOk = false;
            }
            if (string.IsNullOrWhiteSpace(getRegistration.Email))
            {
                MessageBox.Show("Fel email!");
                inputOk = false;
            }
            if (string.IsNullOrWhiteSpace(getRegistration.Address))
            {
                MessageBox.Show("Fel adress!");
                inputOk = false;
            }
            if (string.IsNullOrWhiteSpace(getRegistration.City))
            {
                MessageBox.Show("Fel stad!");
                inputOk = false;
            }
            if (string.IsNullOrWhiteSpace(getRegistration.Username))
            {
                MessageBox.Show("Fel användarnamn!");
                inputOk = false;
            }
            if (string.IsNullOrWhiteSpace(getRegistration.Password))
            {
                MessageBox.Show("Fel lösenord!");
                inputOk = false;
            }

            return inputOk;
        }
    }
}