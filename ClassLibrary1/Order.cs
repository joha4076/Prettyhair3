using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PrettyHairSolution
{
        public interface IOrder
    {
        DateTime DeliveryDate { get; set; }
        int GetOrderID();
        DateTime GetOrderDate();
        DateTime GetDeliveryDate();
        List<IOrderLine> GetWareList();
    }
       public class Order : IOrder
    {
        public Order(int orderid, DateTime deliverydate, DateTime orderdate)
        {
            OrderID = orderid;
            DeliveryDate = deliverydate;
            OrderDate = orderdate;
        }


        public DateTime OrderDate     { get; set; }
        public DateTime DeliveryDate  { get; set; }
        public int OrderID { get; set; }

        List<IOrderLine> OrderList;

        public DateTime GetDeliveryDate()
        {
            return DeliveryDate;
        }

        public DateTime GetOrderDate()
        {
            return OrderDate;
        }

        List<IOrderLine> IOrder.GetWareList()
        {
            return OrderList;
        }

        public int GetOrderID()
        {
            return OrderID;
        }
    }
}
