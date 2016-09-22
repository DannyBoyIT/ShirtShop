using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShirtShop
{
    public class Order : IOrder
    {

        public string List { get; set; }
        public int OrderNumber { get; set; }
        public int PriceSum { get;  set; }

        public void AddProduct()
        {
           
        }

        public void RemoveProduct()
        {
            
        }

        public void SendEmail()
        {
            
        }

        string IOrder.SendEmail()
        {
            return "";
        }
    }
}