using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Task.Classes
{
    public class ExpirableProduct : Product
    {
        public DateTime ExpirationDate { get; }

        public ExpirableProduct(string name, double price, int quantity, DateTime expirationDate)
            : base(name, price, quantity)
        {
            ExpirationDate = expirationDate;
        }

        public override bool IsExpired()
        {
            return DateTime.Now > ExpirationDate;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Expires on: {ExpirationDate.ToShortDateString()}";
        }
    }

}
