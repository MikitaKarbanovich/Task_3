﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Administrator:Person, CallWaiter
    {
        public void FindTable()
        {

        }
        public void SayHello()
        {
            Console.WriteLine("Administrator: Hello dear client!");
        }
        public void AskTypeOfRoom()
        {
            Console.WriteLine("Administrator: You can choose one of two types of the room: 'standart' or 'forsmokers'. Please choose.");
        }
        public void CallWaiter()
        {
            Console.WriteLine("Administrator: Waiter, please go to client");
        }
    }
}
