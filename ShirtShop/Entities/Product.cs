using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShirtShop
{
    public class Product : IProduct
    {
        
        //public int Quantity { get; set; }
       
        public string Name { get; set; }

        public int Price { get; set; }

        public int ProductID { get; set; }

        public string Size { get; set; }

        public string Type { get; set; }

        public string Gender { get; set; }

        public bool IsChild { get; set; }
    }
}