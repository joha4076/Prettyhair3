using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PrettyHairSolution
{
    public interface IOrderRepository
    {
        IOrder DeleteOrderByID(int ID);
        void UpdateOrderByID(IOrder VOrder);
        List<IOrder>GetOrders();
        IOrder GetOrderByID(int ID);
        
    }

    public class OrderRepository : IOrderRepository
    {
        List<IOrder> OrderList = new List<IOrder>();


        public IOrder DeleteOrderByID(int OrderID)
        {
           foreach(IOrder order in OrderList)
            {
                if (order.GetOrderID() == OrderID)
                {
                    OrderList.Remove(order);
                }
            }
            return null;
        }

       public List<IOrder> GetOrders()
        {
            return OrderList;
        }

        public IOrder GetOrderByID(int OrderID)
        {
            foreach(IOrder order in OrderList)
            {
                if (order.GetOrderID() == OrderID)
                {
                    return order;
                }
               
            }
            return null;
        }

        public void UpdateOrderByID(IOrder VOrder)
        {
            foreach(IOrder order in OrderList)
            {
                if (order.GetOrderID() == VOrder.GetOrderID())
                {
                    OrderList.Remove(order);
                    OrderList.Add(VOrder);
                    break;
                }
            }
        }
        public void Add(IOrder order)
        {
            OrderList.Add(order);
        }
        public void Remove(IOrder order)
        {
            OrderList.Remove(order);
        }
    }
}
