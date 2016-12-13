using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.DelegateDB;

namespace ClassLibrary1
{
    public class DelegateClassTest
    {
        static void PrintID(Order o)
        {
            Console.WriteLine(" {0}", o.OrderID);
        }

        public static void Main()
        {
            DelegateDB delegateDB = new DelegateDB();

            AddOrders(delegateDB);

            Console.WriteLine("Order ID's:");

            PriceTotaller pricetotaller = new PriceTotaller();

            delegateDB.ProcessShampoo(new ProcessOrderDelegate(PrintID));

            delegateDB.ProcessShampoo(new ProcessOrderDelegate(pricetotaller.AddShampooTotal));
            Console.WriteLine("Average Orders with Shampoos price: ${0:#.##}", pricetotaller.AveragePrice());

        
        }

            static void AddOrders(DelegateDB delegateDB)
            {
            delegateDB.AddOrder(2994, true, true, true, 1267.00m);
            delegateDB.AddOrder(2000, false, true, true, 999.99m);
            delegateDB.AddOrder(1280, true, false, false, 569.00m);
            delegateDB.AddOrder(999, false, false, false, 000.00m);
            }

        
    }
}
