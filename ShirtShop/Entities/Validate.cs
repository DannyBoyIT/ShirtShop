using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShirtShop.Enums;

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

       
        public static Enum CheckLoggedIn(string inputUsername, string inputPassword)
        {
            DatabaseRepository checkUser = new DatabaseRepository();

            List<User> users = checkUser.GetAllUsers();

            foreach (var user in users)
            {
                if (inputUsername == user.Username && inputPassword == user.Password)
                {
                    if (user.IsAdmin)
                    {
                        MessageBox.Show("Välkomen admin: " + user.FirstName + "!");
                        return Enums.UserTypeEnum.Admin;
                    }
                    else
                    {
                        MessageBox.Show("Välkommen " + user.FirstName + "!");
                        return Enums.UserTypeEnum.User;
                    }

                }
                else if (inputUsername == user.Username && inputPassword != user.Password)
                {
                    MessageBox.Show("Fel lösenord! Försök igen.");
                    return Enums.UserTypeEnum.NoUser;
                }
                else
                {
                    MessageBox.Show("Användarnamnet finns inte i vårt register. Har du skrivit in rätt användarnamn?!");
                }

            }

            return Enums.UserTypeEnum.NoUser;
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