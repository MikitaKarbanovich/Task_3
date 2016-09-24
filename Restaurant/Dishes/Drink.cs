using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dishes
{
    class Drink:Dish
    {
        public double AlcPercentage { get; set; }
        public Drink(string name,double price, int decreaseHungerLevel, double alcPercentage)
        {
            Name = name;
            Price = price;
            DecreaseHungerLevel = decreaseHungerLevel;
            AlcPercentage = alcPercentage;
        }
    }
}
