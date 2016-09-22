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
            throw new NotImplementedException();
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void GetAllShoes()
        {
            throw new NotImplementedException();
        }

        public void GetHat()
        {
            throw new NotImplementedException();
        }

        public void GetShirt()
        {
            throw new NotImplementedException();
        }

        public void GetShoes()
        {
            throw new NotImplementedException();
        }

        public void SetHat()
        {
            throw new NotImplementedException();
        }

        public void SetShirt()
        {
            throw new NotImplementedException();
        }

        public void SetShoes()
        {
            throw new NotImplementedException();
        }
    }
}