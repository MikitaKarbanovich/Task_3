using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Waiter:Person
    {
        public int Speed { get; set; }
        public Waiter(decimal money, int satisfaction, int speed) : base(money, satisfaction)
        {
            Speed = speed;
        }

        public Menu BringMenu(int numberOfTable)
        {
            Menu menu = new Menu();
            menu.ShowAllPossition();
            return menu;
        }
        public Order TakeOrder(Order order, int numberOfTable)
        {
            Console.WriteLine("Waiter take order to cook");
            return order;
        }
        public void BringDish(int numberOfTable)
        {
            //
        }
        public void TakePayment(decimal payment,int numberOfTable)
        {
            this.Money = payment;
            Console.WriteLine("Waiter: I take payment {0}$ and My money is {1}$", payment, this.Money);
        }

    }
}
