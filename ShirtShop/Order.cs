using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShirtShop
{
    public class Order : IOrder
    {
        public string List
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int OrderNumber
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int PriceSum
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void AddProduct()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveProduct()
        {
            throw new System.NotImplementedException();
        }

        public void SendEmail()
        {
            throw new System.NotImplementedException();
        }

        string IOrder.SendEmail()
        {
            throw new NotImplementedException();
        }
    }
}