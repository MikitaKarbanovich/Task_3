using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dishes
{
    public class Drink:Dish
    {
        public double AlcPercentage { get; set; }
        public Drink(string name, decimal price, int decreaseHungerLevel, double alcPercentage) : base(name, price, decreaseHungerLevel)
        {
            AlcPercentage = alcPercentage;
        }
    }
}
