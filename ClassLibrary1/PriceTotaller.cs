using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PriceTotaller 
    {
        int countShampoos = 0;
        decimal priceShampoos = 0.0m;

        internal void AddShampooTotal(Order order)
        {
            countShampoos += 1;
            priceShampoos += order.Price;
        }

        internal decimal AveragePrice()
        {
            return priceShampoos / countShampoos;
        }
    }
}
