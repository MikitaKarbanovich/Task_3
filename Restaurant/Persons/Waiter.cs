using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Waiter:Person
    {
        public Menu BringMenu()
        {
            Menu menu = new Menu();
            return menu;
        }
        public Order TakeOrder(Order order)
        {
            Console.WriteLine("Take order to cook");
            return order;
        }
        public void BringDish()
        {

        }
    }
}
