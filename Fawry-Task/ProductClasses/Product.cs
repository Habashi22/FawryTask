using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Task.Classes
{
    public class Product
    {
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public virtual bool IsExpired()
        {
            return false; // by default, product doesn't expire
        }

        public override string ToString()
        {
            return $"{Name} - Price: {Price:C} - Quantity: {Quantity}";
        }
    }

}
