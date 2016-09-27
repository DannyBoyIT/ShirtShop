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

            var hat1 = new Product();
            hats.Add(hat1);
            hat1.Name = "Filthatt";
            hat1.Price = 499;
            hat1.ProductID = 111;
            hat1.Size = "M";
            hat1.Type = "Hatt";
            hat1.Gender = "Kvinna";
            hat1.IsChild = false;

            var hat2 = new Product();
            hats.Add(hat2);
            hat2.Name = "Solhatt";
            hat2.Price = 249;
            hat2.ProductID = 112;
            hat2.Size = "S";
            hat2.Type = "Hatt";
            hat2.Gender = "Kvinna";
            hat2.IsChild = false;

            var hat3 = new Product();
            hats.Add(hat3);
            hat3.Name = "Keps";
            hat3.Price = 399;
            hat3.ProductID = 113;
            hat3.Size = "L";
            hat3.Type = "Hatt";
            hat3.Gender = "Man";
            hat3.IsChild = false;

            var hat4 = new Product();
            hats.Add(hat4);
            hat4.Name = "Fez";
            hat4.Price = 999;
            hat4.ProductID = 114;
            hat4.Size = "M";
            hat4.Type = "Hatt";
            hat4.Gender = "Man";
            hat4.IsChild = false;

            var hat5 = new Product();
            hats.Add(hat5);
            hat5.Name = "Keps";
            hat5.Price = 399;
            hat5.ProductID = 115;
            hat5.Size = "S";
            hat5.Type = "Hatt";
            hat5.Gender = "Kvinna";
            hat5.IsChild = true;

            return hats;
        }

        public List<Product> GetAllShirts()
        {
            var shirts = new List<Product>();
            
            var shirt1 = new Product();
            shirts.Add(shirt1);
            shirt1.Name = "Röd Peak Performance";
            shirt1.Price = 599;
            shirt1.ProductID = 211;
            shirt1.Size = "42";
            shirt1.Type = "T-shirt";
            shirt1.Gender = "Kvinna";
            shirt1.IsChild = false;

            var shirt2 = new Product();
            shirts.Add(shirt2);
            shirt2.Name = "Blå Gant";
            shirt2.Price = 499;
            shirt2.ProductID = 212;
            shirt2.Size = "40";
            shirt2.Type = "T-shirt";
            shirt2.Gender = "Man";
            shirt2.IsChild = false;

            var shirt3 = new Product();
            shirts.Add(shirt3);
            shirt3.Name = "Grön Adidas";
            shirt3.Price = 399;
            shirt3.ProductID = 213;
            shirt3.Size = "38";
            shirt3.Type = "T-shirt";
            shirt3.Gender = "Kvinna";
            shirt3.IsChild = true;

            var shirt4 = new Product();
            shirts.Add(shirt4);
            shirt4.Name = "Gul H&M";
            shirt4.Price = 199;
            shirt4.ProductID = 214;
            shirt4.Size = "M";
            shirt4.Type = "T-shirt";
            shirt4.Gender = "Man";
            shirt4.IsChild = false;

            var shirt5 = new Product();
            shirts.Add(shirt5);
            shirt5.Name = "Nike";
            shirt5.Price = 399;
            shirt5.ProductID = 215;
            shirt5.Size = "S";
            shirt5.Type = "T-shirt";
            shirt5.Gender = "Man";
            shirt5.IsChild = false;

            return shirts;
        }

        public List<Product> GetAllShoes()
        {
            var shoes = new List<Product>();

            var shoe1 = new Product();
            shoes.Add(shoe1);
            shoe1.Name = "Converse";
            shoe1.Price = 749;
            shoe1.ProductID = 311;
            shoe1.Size = "45";
            shoe1.Type = "Sko";
            shoe1.Gender = "Kvinna";
            shoe1.IsChild = true;

            var shoe2 = new Product();
            shoes.Add(shoe2);
            shoe2.Name = "Nike";
            shoe2.Price = 1099;
            shoe2.ProductID = 312;
            shoe2.Size = "42";
            shoe2.Type = "Sko";
            shoe2.Gender = "Man";
            shoe2.IsChild = false;

            var shoe3 = new Product();
            shoes.Add(shoe3);
            shoe3.Name = "Adidas";
            shoe3.Price = 1199;
            shoe3.ProductID = 313;
            shoe3.Size = "39";
            shoe3.Type = "Sko";
            shoe3.Gender = "Kvinna";
            shoe3.IsChild = false;

            var shoe4 = new Product();
            shoes.Add(shoe4);
            shoe4.Name = "Vagabond";
            shoe4.Price = 1399;
            shoe4.ProductID = 314;
            shoe4.Size = "40";
            shoe4.Type = "Sko";
            shoe4.Gender = "Man";
            shoe4.IsChild = false;

            var shoe5 = new Product();
            shoes.Add(shoe5);
            shoe5.Name = "Nike";
            shoe5.Price = 1399;
            shoe5.ProductID = 315;
            shoe5.Size = "43";
            shoe5.Type = "Sko";
            shoe5.Gender = "Kvinna";
            shoe5.IsChild = false;

            return shoes;
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