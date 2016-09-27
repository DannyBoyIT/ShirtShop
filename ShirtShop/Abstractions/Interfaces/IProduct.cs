using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShirtShop
{
    public interface IProduct
    {
        //int Quantity { get; set; }
        string Name { get; set; }
        int Price { get; set; }
        int ProductID { get; set; }
        string Size { get; set; }
        string Type { get; set; }
        string Gender { get; set; }
        bool IsChild { get; set; }
    }
}