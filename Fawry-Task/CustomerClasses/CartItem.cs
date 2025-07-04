using Fawry_Task.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Task.CustomerClasses
{
    public class CartItem
    {
        public Product Product { get; }
        public int Quantity { get; }

        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public double GetTotalPrice()
        {
            return Product.Price * Quantity;
        }

        public double GetShippingFee()
        {
            if (Product is ShippableProduct shippable)
            {
                return shippable.ShippingFee;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{Product.Name} x{Quantity} - Total: {GetTotalPrice():C}";
        }
    }

}
