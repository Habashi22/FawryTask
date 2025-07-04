using Fawry_Task.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Task.Service
{
    public static class ShippingService
    {
        public static void ShipItems(List<IShippable> items)
        {
            Console.WriteLine("Shipping the following items:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.GetName()}, Weight: {item.GetWeight()} kg");
            }
        }
    }

}
