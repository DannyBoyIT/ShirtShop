using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShirtShop
{
    public interface IAdmin
    {
        void AddProduct();
        void ChangeProduct();
        void RemoveProduct();
    }
}