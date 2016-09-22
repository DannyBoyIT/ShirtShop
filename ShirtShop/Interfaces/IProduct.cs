using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShirtShop
{
    public interface IProduct
    {
        int Contity { get; set; }
        string Name { get; set; }
        int Price { get; set; }
        int ProductID { get; set; }
        int Size { get; set; }
        string Type { get; set; }
    }
}