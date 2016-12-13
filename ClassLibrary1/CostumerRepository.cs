using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PrettyHairSolution
{
      public interface ICustomerRepository
    {
       ICustomer FindCustomer(int CustomerNumber);
    }


    public class CustomerRepository : ICustomerRepository
    {

        public List<ICustomer> CustomerList = new List<ICustomer>();

        public CustomerRepository()
        {

        }
        
        public ICustomer FindCustomer(int CustomerNumber)

        {
            foreach(ICustomer Customer in CustomerList)
            {
                if (Customer.GetCustomerNumber() == CustomerNumber)
                {
                    return Customer;
                }
            }
            return null;
        }


        public void Add(ICustomer customer)
        {
            CustomerList.Add(customer);
        }
    }
}
