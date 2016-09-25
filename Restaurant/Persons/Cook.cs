using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Cook:Person
    {
        public bool Cooking(Order order)
        {
            foreach (OrderItem orderItem in order.OrderItes)
            {
                Console.WriteLine("Cook: is cooking  {0} [{1}]", orderItem.Name, orderItem.TypeOfDish);
            }
            bool isCooked = true;
            return isCooked;
        }
    }
}
