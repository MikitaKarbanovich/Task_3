using Restaurant.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(200,0,4);
            Administrator admin = new Administrator();
            Waiter waiter = new Waiter();
            Cook cook = new Cook();
            Console.WriteLine("Our client's hunger level is {0}, he/she has {1}$ money and his/her satisfaction is {2}.",client.HungerLeverl, client.Money,client.Satisfaction);
            admin.SayHello();
            admin.AskTypeOfRoom();
            if (client.ChooseTypeOfRoom("standart") == 1)
            {
                RoomStandart standartRoom = new RoomStandart();
                Menu menu = new Menu();
                Order order;
                int numberOfTable=standartRoom.ChooseFreeTable();
                admin.CallWaiter(numberOfTable);
                menu = waiter.BringMenu(numberOfTable);
                OrderItem orderItem1 = new OrderItem();
                OrderItem orderItem2 = new OrderItem();
                orderItem1.TypeOfDish = TypeOfDish.MainCourse;
                orderItem1.Name = "Beef steak";
                orderItem1.Quantity = 1;
                orderItem2.TypeOfDish = TypeOfDish.Dessert;
                orderItem2.Name = "Cake";
                orderItem2.Quantity = 2;
                order = client.MakeOrder(orderItem1, orderItem2);
                waiter.TakeOrder(order, numberOfTable);
                bool isCooked;
                isCooked = cook.Cooking(order);
                if (isCooked)
                {
                    client.Eat(order);
                    Console.WriteLine("After eating client hunger level is {0}", client.Eat(order));
                    double payment = client.Pay(order);
                    waiter.TakePayment(payment, numberOfTable);
                }
                Console.ReadKey();
            }
        }
    }
}
