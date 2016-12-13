using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassLibrary1
{
         public struct Order
      {
        public int OrderID;
        public bool Shampoo;
        public bool Scissor;
        public bool Conditioner;
        public decimal Price;

        public Order(int orderID, bool shampoo, bool scissor, bool conditioner, decimal price)
        {
            OrderID = orderID;
            Shampoo = shampoo;
            Scissor = scissor;
            Conditioner = conditioner;
            Price = price;
        }
      }
    public class DelegateDB
    {
        public delegate void ProcessOrderDelegate(Order order);
        
            ArrayList list = new ArrayList();

            public void AddOrder(int orderID, bool shampoo, bool scissor, bool conditioner, decimal price)
            {
            list.Add(new Order(orderID, shampoo, scissor, conditioner, price));
            }

        public void ProcessShampoo(ProcessOrderDelegate processShampoo)
        {
            foreach(Order o in list)
            {
                if (o.Shampoo)
                {
                    processShampoo(o);
                }
            }
        }
     }
    
}
