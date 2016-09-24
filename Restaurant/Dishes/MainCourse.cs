using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dishes
{
    class MainCourse:Dish
    {
        public string TypeOfMeat { get; set; }
        public MainCourse(string name, double price, int decreaseHungerLevel, string typeOfMeat)
        {
            Name = name;
            Price = price;
            DecreaseHungerLevel = decreaseHungerLevel;
            TypeOfMeat = typeOfMeat;
        }
    }
}
