using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant;
using Restaurant.Rooms;

namespace UnitTests
{
    [TestClass]
    public class RestaurantTest
    {
        [TestMethod]
        public void TestSetClientHungerLevel()
        {
            Client client = new Client(200, 0, 55);
            Assert.AreEqual(10, client.HungerLeverl);
        }
        [TestMethod]
        public void TestClientChooseTypeOfRoom()
        {
            Client client = new Client(200, 0, 55);
            Assert.AreEqual(1, client.ChooseTypeOfRoom("standart"));
            Assert.AreEqual(1, client.ChooseTypeOfRoom("StANDaRt"));
            Assert.AreNotEqual(1, client.ChooseTypeOfRoom("standartmaybe"));
        }
        [TestMethod]
        public void TestClientEat()
        {
            Client client = new Client(200, 0, 7);
            Order order = new Order();
            OrderItem orderItem1 = new OrderItem();
            OrderItem orderItem2 = new OrderItem();
            orderItem1.TypeOfDish = TypeOfDish.MainCourse;
            orderItem1.Name = "Beef steak";
            orderItem1.Quantity = 1;
            orderItem2.TypeOfDish = TypeOfDish.Dessert;
            orderItem2.Name = "Cake";
            orderItem2.Quantity = 2;
            order = client.MakeOrder(orderItem1, orderItem2);
            Assert.AreEqual(1, client.Eat(order));
        }
        [TestMethod]
        public void TestStandartRoomConstructor()
        {
            RoomStandart standartRoom = new RoomStandart();
            foreach (Table table in standartRoom.Tables)
            {
                Assert.AreEqual(true, table.IsVacant);
            }
        }
        [TestMethod]
        public void TestStandartRoomChooseTable()
        {
            RoomStandart standartRoom = new RoomStandart();
            Assert.AreEqual(0, standartRoom.ChooseFreeTable());
        }
        [TestMethod]
        public void TestClientMakeOrder()
        {
            Order order = new Order();
            Client client = new Client(200, 0, 4);
            OrderItem orderItem1 = new OrderItem();
            OrderItem orderItem2 = new OrderItem();
            orderItem1.TypeOfDish = TypeOfDish.MainCourse;
            orderItem1.Name = "Beef steak";
            orderItem1.Quantity = 1;
            orderItem2.TypeOfDish = TypeOfDish.Dessert;
            orderItem2.Name = "Cake";
            orderItem2.Quantity = 2;
            order = client.MakeOrder(orderItem1, orderItem2);
            Assert.AreEqual(orderItem1, order.OrderItes[0]);
        }
    }
}
