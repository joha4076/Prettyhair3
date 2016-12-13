using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _PrettyHairSolution;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindCustomerInCustomerRepository()
        {
            Customer customer = new Customer("Karl", 1);
            CustomerRepository costumerRepository = new CustomerRepository();
            costumerRepository.Add(customer);
            ICustomer x2 = costumerRepository.FindCustomer(customer.CustomerNumber);
              
            Assert.AreEqual("Karl", customer.Name);
            Assert.AreEqual(1, x2.CustomerNumber);
           
        }

        [TestMethod]
        public void FindAOrdersIDAndDeliveryDate()
        {
            DateTime orderdate = new DateTime(1996, 4, 12);
            DateTime deliverydate = new DateTime(1996, 4, 22);
            Order order = new Order(294, deliverydate, orderdate);
            OrderRepository orderRepository = new OrderRepository();
            orderRepository.Add(order);
            IOrder iorder = orderRepository.GetOrderByID(order.OrderID);

            Assert.AreEqual(294, order.OrderID);
            Assert.AreEqual(deliverydate, iorder.DeliveryDate);
        }

        [TestMethod]
        public void DeleteOrderFromOrderRepository()
        {
            DateTime orderdate = new DateTime(2004, 8, 9);
            DateTime deliverydate = new DateTime(2004, 8, 20);
            Order order = new Order(120, deliverydate, orderdate);
            OrderRepository orderRepository = new OrderRepository();
            IOrder DO = orderRepository.DeleteOrderByID(order.OrderID);    //   DO = Delete Order
            orderRepository.Remove(order);

            Assert.AreEqual(120, order.OrderID);
        }
    }
}
