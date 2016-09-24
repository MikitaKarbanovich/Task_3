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
                foreach (Table table in standartRoom.Tables)
                {
                    if (table.IsVacant)
                    {
                        Console.WriteLine("Table № {0} choosed by Client",table.NameOfTable);
                        table.IsVacant = false;
                        break;
                    }
                }
                foreach (Table table in standartRoom.Tables)
                {
                    
                        Console.WriteLine("Table № {0} in status  {1}", table.NameOfTable,table.IsVacant);
                }
            }
            admin.CallWaiter();
            Menu menu = new Menu();
            Order order;
            menu=waiter.BringMenu();
            order=client.MakeOrder(menu);
            waiter.TakeOrder(order);
            bool isCooked;
            isCooked=cook.Cooking(order);
            if (isCooked)
            {
                client.Eat();
                client.Pay(order);
            }
            Console.ReadKey();
        }
    }
}
