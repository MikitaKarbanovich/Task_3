using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
   public abstract class  Person
    {
        public int Satisfaction { get; set; }
        public decimal Money { get; set; }
        public Person(decimal money, int satisfaction)
        {
            Money = money;
            Satisfaction = satisfaction;
        }
    }
}
