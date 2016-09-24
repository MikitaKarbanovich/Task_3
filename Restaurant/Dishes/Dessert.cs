using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dishes
{
    class Dessert:Dish
    {
        public int ShugarValue { get; set; }
        public Dessert(string name, double price,int decreaseHungerLevel,int shugarValue)
        {
            Name = name;
            Price = price;
            DecreaseHungerLevel = decreaseHungerLevel;
            ShugarValue = shugarValue;
        }
    }
}
