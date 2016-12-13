using System;

namespace _PrettyHairSolution
{
    public interface Iware
    {
        int GetID();
        int GetPrice();
        string GetDesignation();
        int GetQuantity();
        ProductType ProductType   { get; set; }
        ProductType GetProductType();
    }

    public enum ProductType
    {
        Saks, Shampoo, Balsam, Hårdfarve
    }

    public class ware : Iware
    {
        public int ID             { get; set; }
        public int Price          { get; set; }
        public string Designation { get; set; }
        public ProductType ProductType { get; set; }
        public int Quantity       { get; set; }

        public ware()
        {
        }

        public int GetID()
        {
            return ID;
        }

        public int GetPrice()
        {
            return Price;
        }

        public string GetDesignation()
        {
            return Designation;
        }

        public ProductType GetProductType()
        {
            return ProductType;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        
    }
}