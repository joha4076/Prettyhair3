using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PrettyHairSolution
{
    public interface IItemRepository
    {
        void DeleteWareByID(int ID);
        void UpdateWare(Iware ware);
        List<Iware> getWares();
        Iware GetWareByID(int ID);
    }

    public class ItemRepository : IItemRepository
    {
        private List<Iware> wareList;

        public void DeleteWareByID(int ID)
        {
            foreach(Iware item in wareList)
            {
                if (item.GetID() == ID)
                {
                    wareList.Remove(item);
                }
            }
        }

        public Iware GetWareByID(int ID)
        {
            foreach(Iware item in wareList)
            {
                if (item.GetID() == ID)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Iware> getWares()
        {
            return wareList;
        }

        public void UpdateWare(Iware ware)
        {
            foreach(Iware item in wareList)
            {
                if(item.GetID() == ware.GetID())
                {
                    wareList.Remove(item);
                    wareList.Add(ware);
                    //item.Price = ware.GetPrice(); //Virker ikke hvis man bruger interface
                    //item.Designation = ware.GetDesignation(); //Virker ikke hvis man bruger interface
                    break;
                }
            }
        }
    }
}
