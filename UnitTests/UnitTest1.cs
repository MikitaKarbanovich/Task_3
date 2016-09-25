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
            Client client = new Client(200, 0, 5);
            Assert.AreEqual(5, client.HungerLeverl);
            client.HungerLeverl = -10;
            Assert.AreEqual(0, client.HungerLeverl);
            client.HungerLeverl = 55;
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
        public void TestOrderPay()
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
            //payment for test order is 21.5
            order = client.MakeOrder(orderItem1, orderItem2);
            Assert.AreEqual(21.5m, order.PaymentCalculation());
        }
        [TestMethod]
        public void TestOrderHungerCalculation()
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
            //Total DecreaseHungerLevel for test order is 6
            order = client.MakeOrder(orderItem1, orderItem2);
            Assert.AreEqual(6, order.HungerLevelCalculation());
        }
        [TestMethod]
        public void TestStandartRoomConstructor()
        {
            RoomStandart standartRoom = new RoomStandart();
            //standartRoom default  have 2 vacant tables
            foreach (Table table in standartRoom.Tables)
            {
                Assert.AreEqual(true, table.IsVacant);
            }
        }
        [TestMethod]
        public void TestStandartRoomChooseTable()
        {
            RoomStandart standartRoom = new RoomStandart();
            // Should be chosen the first table, because method find the first empty table and make it busy. 
            Assert.AreEqual(1, standartRoom.ChooseFreeTable());
            // At second time should  be chosen the second table, because the first is busy.
            Assert.AreEqual(2, standartRoom.ChooseFreeTable());
            // All tables in standart room should't be vacant.
            foreach (Table table in standartRoom.Tables)
            {
                Assert.AreEqual(false, table.IsVacant);
            }
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
        [TestMethod]
        public void TestWaiterTakeOrder()
        {
            Order order = new Order();
            Waiter waiter = new Waiter(0,0);
            Assert.AreEqual(order, waiter.TakeOrder(order,3));
        }
    }
}
