using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dishes
{
    public class MainCourse:Dish
    {
        public string TypeOfMeat { get; set; }
        public MainCourse(string name, decimal price, int decreaseHungerLevel, string typeOfMeat) : base(name, price, decreaseHungerLevel)
        {
            TypeOfMeat = typeOfMeat;
        }
    }
}
