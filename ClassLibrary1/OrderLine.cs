using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PrettyHairSolution
{
    public interface IOrderLine
    {
        Iware GetWare();
        int GetAmount();
        double GetPriceTotal();
    }
    public class OrderLine : IOrderLine
    {
        public int Amount { get; set; }
        public Iware Ware { get; set; }
        public double PriceTotal { get; set; }
        public int GetAmount()
        {
            return Amount;
        }

        public Iware GetWare()
        {
            return Ware;
        }

        public double GetPriceTotal()
        {
            return Ware.GetPrice() * Amount;
        }
    }
}
