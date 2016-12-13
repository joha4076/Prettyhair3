using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PrettyHairSolution
{
   public  interface ICustomer
    {
        int CustomerNumber { get; set; }
        int GetCustomerNumber();
        string GetName();
        string GetAddress();
    }

   public class Customer : ICustomer
    {
        public Customer(string v1, int v2)
        {
            Name = v1;
            CustomerNumber = v2;
        }

        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string GetAddress()
        {
            return Address;
        }

        public int GetCustomerNumber()
        {
            return CustomerNumber;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
