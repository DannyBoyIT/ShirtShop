using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShirtShop
{
    public interface IDatabaseRepository
    {
        void CreateUser();
        void DeleteUser();
        void GetAllHats();
        void GetAllShirts();
        void GetAllShoes();
        void GetHat();
        void GetShirt();
        void GetShoes();
        void SetHat();
        void SetShirt();
        void SetShoes();
    }
}