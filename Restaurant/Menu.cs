using Restaurant.Dishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Menu
    {
        private List<Dessert> desserts = new List<Dessert>();
        public List<Dessert> Desserts { get { return desserts; } set { desserts = value; } }
        private List<Drink> drinks = new List<Drink>();
        public List<Drink> Drinks { get { return drinks; } set { drinks = value; } }
        private List<MainCourse> mainCourses = new List<MainCourse>();
        public List<MainCourse> MainCourses { get { return mainCourses; } set { mainCourses = value; } }
        private List<Starter> starters = new List<Starter>();
        public List<Starter> Starters { get { return starters; } set { starters = value; } }


        public Menu()
        {
            Dessert cake = new Dessert("Cake", 5, 1, 1);
            Dessert iceCream = new Dessert("Ice cream", 2, 1, 1);
            Drink pepsi = new Drink("Pepsi", 0.5,1,0);
            Drink lidskoe = new Drink("Beer Lidskoe", 1.5, 1, 4.5);
            MainCourse beefSteak = new MainCourse("Beef steak", 11.5, 4,"beef");
            Desserts.Add(cake);
            Desserts.Add(iceCream);
            Drinks.Add(pepsi);
            Drinks.Add(lidskoe);
            MainCourses.Add(beefSteak);
        }
        public void ShowAllPossition()
        {
            Console.WriteLine("\n>>> M E N U <<<");
            Console.WriteLine("Desserts:");
            foreach (Dessert dessert in this.Desserts)
            {

                Console.WriteLine("Name: {0} Price: {1} ShugarValue: {2}",dessert.Name, dessert.Price, dessert.ShugarValue);
            }
            Console.WriteLine("Drinks:");
            foreach (Drink drink in this.Drinks)
            {
                Console.WriteLine("Name: {0}| Price: {1}| Alcohol percentage: {2}", drink.Name, drink.Price, drink.AlcPercentage);
            }
            Console.WriteLine("Maincourses:");
            foreach (MainCourse mainCourse in this.MainCourses)
            {
                Console.WriteLine("Name: {0}| Price: {1}| Type of meat: {2}", mainCourse.Name, mainCourse.Price, mainCourse.TypeOfMeat);
            }
            Console.WriteLine("\n");
        }
    }
}
