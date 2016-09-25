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
            admin.SayHello();
            admin.AskTypeOfRoom();
            if (client.ChooseTypeOfRoom("standart") == 1)
            {
                RoomStandart standartRoom = new RoomStandart();
                int numberOfTable=standartRoom.ChooseFreeTable();
                Console.WriteLine(numberOfTable);
                admin.CallWaiter(numberOfTable);
                Menu menu = new Menu();
                Order order;
                menu = waiter.BringMenu(numberOfTable);
                order = client.MakeOrder(menu);
                waiter.TakeOrder(order, numberOfTable);
                bool isCooked;
                isCooked = cook.Cooking(order);
                if (isCooked)
                {
                    client.Eat(order);
                    double payment = client.Pay(order);
                    waiter.TakePayment(payment, numberOfTable);
                }
                Console.ReadKey();
            }
        }
    }
}
