using Fawry_Task.Classes;
using Fawry_Task.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Task.CustomerClasses
{
    public class Customer
    {
        public string Name { get; }
        public double Balance { get; private set; }
        public Cart Cart { get; } = new Cart();

        public Customer(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public void AddToCart(Product product, int quantity)
        {
            Cart.AddProduct(product, quantity);
        }

        public void Checkout()
        {
            if (Cart.IsEmpty())
            {
                Console.WriteLine("Error: Cart is empty.");
                return;
            }

            foreach (var item in Cart.Items)
            {
                if (item.Product.IsExpired())
                {
                    Console.WriteLine($"Error: {item.Product.Name} is expired.");
                    return;
                }

                if (item.Product.Quantity < item.Quantity)
                {
                    Console.WriteLine($"Error: Not enough stock for {item.Product.Name}.");
                    return;
                }
            }

            double total = Cart.GetTotal();
            if (Balance < total)
            {
                Console.WriteLine("Error: Insufficient balance.");
                return;
            }

            Balance -= total;

            // Reduce stock
            foreach (var item in Cart.Items)
            {
                item.Product.Quantity -= item.Quantity;
            }

            // Print summary
            Console.WriteLine("Checkout Summary:");
            Console.WriteLine($"Subtotal: {Cart.GetSubtotal():C}");
            Console.WriteLine($"Shipping Fees: {Cart.GetShippingFees():C}");
            Console.WriteLine($"Total Paid: {total:C}");
            Console.WriteLine($"Remaining Balance: {Balance:C}");

            // Handle shipping
            var shippables = Cart.GetShippableItems();
            if (shippables.Any())
            {
                ShippingService.ShipItems(shippables);
            }

            Cart.Clear();
        }
    }

}
