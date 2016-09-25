using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Administrator:Person, ICallWaiter
    {
        const int SAYHELLOSATISFACTION = 1;
        public int CommunicationSkill { get; set; }
        public Administrator(decimal money, int satisfaction, int communicationSkill) : base(money, satisfaction)
        {
            CommunicationSkill = communicationSkill;
        }

        public int SayHello()
        {
            Console.WriteLine("Administrator: Hello dear client!");
            return SAYHELLOSATISFACTION;
        }
        public void AskTypeOfRoom()
        {
            Console.WriteLine("Administrator: You can choose one of two types of the room: 'standart' or 'forsmokers'. Please choose.");
        }
        public void CallWaiter(int numberOfTable)
        {
            Console.WriteLine("Administrator: Waiter, please go to client, table № {0}",numberOfTable);
        }
    }
}
