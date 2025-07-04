using Fawry_Task.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Task.Classes
{
    public class ShippableProduct : Product, IShippable
    {
        public double Weight { get; }
        public double ShippingFee { get; }

        public ShippableProduct(string name, double price, int quantity, double weight, double shippingFee)
            : base(name, price, quantity)
        {
            Weight = weight;
            ShippingFee = shippingFee;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {
            return Weight;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Weight: {Weight} kg - Shipping Fee: {ShippingFee:C}";
        }
    }

}
