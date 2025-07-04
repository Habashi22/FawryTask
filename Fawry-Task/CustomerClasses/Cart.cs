using Fawry_Task.Classes;
using Fawry_Task.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Task.CustomerClasses
{
    public class Cart
    {
        private List<CartItem> items = new List<CartItem>();

        public IReadOnlyList<CartItem> Items => items;

        public void AddProduct(Product product, int quantity)
        {
            if (product.Quantity < quantity)
            {
                throw new InvalidOperationException($"Cannot add {quantity} of {product.Name}. Only {product.Quantity} available.");
            }

            items.Add(new CartItem(product, quantity));
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public double GetSubtotal()
        {
            return items.Sum(item => item.GetTotalPrice());
        }

        public double GetShippingFees()
        {
            return items.Sum(item => item.GetShippingFee());
        }

        public double GetTotal()
        {
            return GetSubtotal() + GetShippingFees();
        }

        public List<IShippable> GetShippableItems()
        {
            return items
                .Where(item => item.Product is IShippable)
                .Select(item => (IShippable)item.Product)
                .ToList();
        }

        public void Clear()
        {
            items.Clear();
        }
    }

}
