using Restaurant.Dishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public enum TypeOfRoom
    {
        Standart = 1,
        ForSmokers
    }
    public class Client:Person, ICallWaiter
    {
        int hungerLevel;
        public int HungerLeverl
        {
            get { return hungerLevel; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    hungerLevel = value;
                }
                else if (value <= 0)
                {
                    hungerLevel = 0;
                }
                else if (value >= 10)
                {
                    hungerLevel = 10;
                }
            }
        }
        public Client(decimal money, int satisfaction, int hungryLevel): base (money,satisfaction)
        {
            HungerLeverl = hungryLevel;
        }

        public int ChooseTypeOfRoom(string typeOfRoom)
        {
            if (typeOfRoom.ToLower().Equals("standart"))
            {
                Console.WriteLine("Client: standart");
                return (int)TypeOfRoom.Standart;
            }
            else if (typeOfRoom.ToLower().Equals("forsmokers"))
            {
                Console.WriteLine("Client: forsmokers");
                return (int)TypeOfRoom.ForSmokers;
            }
            else
            {
                Console.WriteLine("0");
                return 0;
            }
        }
        public void CallWaiter(int numberOfTable)
        {
            Console.WriteLine("Client: Waiter, please go to me, table № {0}", numberOfTable);
        }
        public Order MakeOrder(OrderItem orderItem, OrderItem orderItem1)
        {
            Order order = new Order();
            order.OrderItes.Add(orderItem);
            order.OrderItes.Add(orderItem1);
            return order;
        }
        public int Eat(Order order)
        {
            
            this.HungerLeverl= (this.HungerLeverl - order.HungerLevelCalculation());
            Console.WriteLine("Client: Om-Nom-nom!");
            return this.HungerLeverl;
        }
        public decimal Pay(Order order)
        {
            this.Money=this.Money- order.PaymentCalculation();
            Console.WriteLine("Client: I pay {0}$ and My money is  {1}$", order.PaymentCalculation(), this.Money);
            return order.PaymentCalculation();
        }
    }
}
