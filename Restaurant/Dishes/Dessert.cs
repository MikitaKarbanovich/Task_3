using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dishes
{
    public class Dessert:Dish
    {
        public int ShugarValue { get; set; }
        public Dessert(string name, decimal price,int decreaseHungerLevel,int shugarValue):base(name,price, decreaseHungerLevel)
        {
            ShugarValue = shugarValue;
        }
    }
}
