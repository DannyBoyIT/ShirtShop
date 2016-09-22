using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShirtShop
{
    public class DatabaseRepository : IDatabaseRepository
    {
        public void CreateUser()
        {
            
        }

        public void DeleteUser()
        {
            
        }

        public List<User> GetAllUsers()
        {
            List<User> getUsers = new List<User>();

            User User1 = new User();            
  
            User1.FirstName = "Jacob";
            User1.LastName = "Svensson";
            User1.Email = "kek@gmail.com";
            User1.Address = "Fyren 35";
            User1.City = "Stockholm";
            User1.Telephone = "07292828";
            User1.Username = "Yeahowwioe";
            User1.Password = "1234";

            getUsers.Add(User1);

            return getUsers;
        }

        public List<Product> GetAllHats()
        {
            var hats = new List<Product>();

            var hat = new Product();
            hats.Add(hat);
            //hat.Quantity = 4;
            hat.Name = "Filthatt";
            hat.Price = 499;
            hat.ProductID = 111;
            hat.Size = "M";
            hat.Type = "Hat";

            return hats;
        }

        public void GetAllShirts()
        {
            
        }

        public void GetAllShoes()
        {
            
        }

        public void GetHat()
        {
            
        }

        public void GetShirt()
        {
            
        }

        public void GetShoes()
        {
            
        }

        public void SetHat()
        {
            
        }

        public void SetShirt()
        {
            
        }

        public void SetShoes()
        {
            
        }
    }
}