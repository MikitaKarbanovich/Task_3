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
                if (value > 0 && value < 11)
                {
                    hungerLevel = value;
                }
                else
                {
                    if (hungerLevel < 0)
                    {
                        hungerLevel = 0;
                    }
                    else
                    {
                        hungerLevel = 10;
                    }
                }

            }
        }
        public Client(double money, int satisfaction, int hungryLevel)
        {
            Money = money;
            Satisfaction = satisfaction;
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
            Console.WriteLine("Client: Waiter, please go to me.");
        }
        public Order MakeOrder(Menu menu)
        {
            menu.ShowAllPossition();
            Order order = new Order();
            OrderItem orderItem = new OrderItem();
            OrderItem orderItem1 = new OrderItem();
            orderItem1.TypeOfDish = TypeOfDish.MainCourse;
            orderItem1.Name = "Beef steak";
            orderItem1.Quantity = 1;
            orderItem.TypeOfDish = TypeOfDish.Dessert;
            orderItem.Name = "Cake";
            orderItem.Quantity = 2;
            order.OrderItes.Add(orderItem);
            order.OrderItes.Add(orderItem1);
            return order;
        }
        public void Eat()
        {
            Console.WriteLine("Client: Om-Nom-nom!");
        }
        public double Pay(Order order)
        {
            this.Money=this.Money- order.OrderCalculation();
            Console.WriteLine("Client: I pay {0}$ and My money is  {1}$", order.OrderCalculation(), this.Money);
            return order.OrderCalculation();
        }
    }
}
