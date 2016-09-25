using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dishes
{
    public abstract class Dish
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int DecreaseHungerLevel { get; set; }
        public Dish(string name, decimal price, int decreaseHungerLevel)
        {
            Name = name;
            Price = price;
            DecreaseHungerLevel = decreaseHungerLevel;
        }
    }
}
