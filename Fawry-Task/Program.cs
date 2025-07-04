using Fawry_Task.Classes;
using Fawry_Task.CustomerClasses;

namespace Fawry_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Products
            var cheese = new ExpirableProduct("Cheese 400g", 100, 10, DateTime.Now.AddDays(5));
            var biscuits = new ExpirableProduct("Biscuits 700g", 150, 5, DateTime.Now.AddDays(3));
            var tv = new ShippableProduct("TV", 300, 3, 7.0, 30); // shippable but not expirable
            var scratchCard = new Product("Scratch Card", 50, 100); // not expirable or shippable

            // Wrap cheese and biscuits as shippable+expirable using composition or hybrid subclass
            var cheeseShippable = new ShippableProduct("Cheese 400g", cheese.Price, cheese.Quantity, 0.5, 10);
            var biscuitsShippable = new ShippableProduct("Biscuits 700g", biscuits.Price, biscuits.Quantity, 0.6, 20);

            // Create Customer
            var customer = new Customer("Alice", 1000);

            try
            {
                // Add items to cart
                customer.AddToCart(cheeseShippable, 2);
                customer.AddToCart(biscuitsShippable, 1);
                customer.AddToCart(scratchCard, 1);

                // Checkout
                customer.Checkout();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
            }
        }
    }

}
