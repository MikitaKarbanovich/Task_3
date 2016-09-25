using Restaurant.Dishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Order
    {
        List<OrderItem> orderItems = new List<OrderItem>();
        public List<OrderItem> OrderItes { get { return orderItems; } set { orderItems = value; } }

        public double PaymentCalculation()
        {
            Menu menu = new Menu();
            double sumOfBill=0;
            foreach (OrderItem orderItem in this.OrderItes)
            {
                switch (orderItem.TypeOfDish)
                {
                    case TypeOfDish.Dessert:
                        foreach (Dessert dessert in menu.Desserts)
                        {
                            if (dessert.Name.Equals(orderItem.Name))
                            {
                                sumOfBill += dessert.Price * orderItem.Quantity;
                            }
                        }
                        break;
                    case TypeOfDish.Drink:
                        foreach (Drink drink in menu.Drinks)
                        {
                            if (drink.Name.Equals(orderItem.Name))
                            {
                                sumOfBill += drink.Price * orderItem.Quantity;
                            }
                        }
                        break;
                    case TypeOfDish.MainCourse:
                        foreach (MainCourse mainCourse in menu.MainCourses)
                        {
                            if (mainCourse.Name.Equals(orderItem.Name))
                            {
                                sumOfBill += mainCourse.Price * orderItem.Quantity;
                            }
                        }
                        break;
                    case TypeOfDish.Starter:
                        foreach (Starter starter in menu.Starters)
                        {
                            if (starter.Name.Equals(orderItem.Name))
                            {
                                sumOfBill += starter.Price * orderItem.Quantity;
                            }
                        }
                        break;
                    default: Console.WriteLine("Default");
                        break;
                }
            }
            return sumOfBill;
        }
        public int HungerLevelCalculation()
        {
            Menu menu = new Menu();
            int hungerLevel=0;
            foreach (OrderItem orderItem in this.OrderItes)
            {
                switch (orderItem.TypeOfDish)
                {
                    case TypeOfDish.Dessert:
                        foreach (Dessert dessert in menu.Desserts)
                        {
                            if (dessert.Name.Equals(orderItem.Name))
                            {
                                hungerLevel += dessert.DecreaseHungerLevel * orderItem.Quantity;
                            }
                        }
                        break;
                    case TypeOfDish.Drink:
                        foreach (Drink drink in menu.Drinks)
                        {
                            if (drink.Name.Equals(orderItem.Name))
                            {
                                hungerLevel += drink.DecreaseHungerLevel * orderItem.Quantity;
                            }
                        }
                        break;
                    case TypeOfDish.MainCourse:
                        foreach (MainCourse mainCourse in menu.MainCourses)
                        {
                            if (mainCourse.Name.Equals(orderItem.Name))
                            {
                                hungerLevel += mainCourse.DecreaseHungerLevel * orderItem.Quantity;
                            }
                        }
                        break;
                    case TypeOfDish.Starter:
                        foreach (Starter starter in menu.Starters)
                        {
                            if (starter.Name.Equals(orderItem.Name))
                            {
                                hungerLevel += starter.DecreaseHungerLevel * orderItem.Quantity;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Default");
                        break;
                }
            }
            return hungerLevel;
        }

    }
    public class OrderItem
    {
        public TypeOfDish TypeOfDish { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
    public enum TypeOfDish
    {
        Dessert = 1,
        Drink,
        MainCourse,
        Starter
    }
}
