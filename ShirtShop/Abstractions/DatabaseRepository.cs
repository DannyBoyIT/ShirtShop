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
            hat.Name = "Filthatt";
            hat.Price = 499;
            hat.ProductID = 111;
            hat.Size = "M";
            hat.Type = "Hatt";

            var hat2 = new Product();
            hats.Add(hat2);
            hat2.Name = "Solhatt";
            hat2.Price = 249;
            hat2.ProductID = 112;
            hat2.Size = "S";
            hat2.Type = "Hatt";

            var hat3 = new Product();
            hats.Add(hat3);
            hat3.Name = "Keps";
            hat3.Price = 399;
            hat3.ProductID = 113;
            hat3.Size = "L";
            hat3.Type = "Hatt";

            var hat4 = new Product();
            hats.Add(hat4);
            hat4.Name = "Fez";
            hat4.Price = 999;
            hat4.ProductID = 114;
            hat4.Size = "M";
            hat4.Type = "Hatt";

            var hat5 = new Product();
            hats.Add(hat5);
            hat5.Name = "Keps";
            hat5.Price = 399;
            hat5.ProductID = 115;
            hat5.Size = "S";
            hat5.Type = "Hatt";

            return hats;
        }

        public void GetAllShirts()
        {
            var shirts = new List<Product>();

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