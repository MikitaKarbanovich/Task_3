using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant;
using Restaurant.Rooms;

namespace UnitTests
{
    [TestClass]
    public class RestaurantMethodsTest
    {
        Administrator admin;
        Client client;
        Order order;
        Waiter waiter;
        RoomStandart standartRoom;
        OrderItem orderItem1;
        OrderItem orderItem2;

        [TestInitialize()]
        public void TestInitialize()
        {
            admin = new Administrator(0, 0, 10);
            client = new Client(200m, 5, 5);
            order = new Order();
            waiter = new Waiter(10m,2,2);
            standartRoom = new RoomStandart();
            orderItem1 = new OrderItem();
            orderItem2 = new OrderItem();
            orderItem1.TypeOfDish = TypeOfDish.MainCourse;
            orderItem1.Name = "Beef steak";
            orderItem1.Quantity = 1;
            orderItem2.TypeOfDish = TypeOfDish.Dessert;
            orderItem2.Name = "Cake";
            orderItem2.Quantity = 2;
            order = client.MakeOrder(orderItem1, orderItem2);
        }
        [TestCleanup()]
        public void TestCleanUp()
        {
            client = null;
            order = null;
            orderItem1 = null;
            orderItem2 = null;
            waiter = null;
            standartRoom = null;
        }

        [TestMethod]
        public void TestSetClientHungerLevel()
        {
            Assert.AreEqual(5, client.HungerLeverl);
            client.HungerLeverl = -10;
            Assert.AreEqual(0, client.HungerLeverl);
            client.HungerLeverl = 55;
            Assert.AreEqual(10, client.HungerLeverl);
        }
        [TestMethod]
        public void TestClientChooseTypeOfRoom()
        {
            Assert.AreEqual(1, client.ChooseTypeOfRoom("standart"));
            Assert.AreEqual(1, client.ChooseTypeOfRoom("StANDaRt"));
            Assert.AreNotEqual(1, client.ChooseTypeOfRoom("standartmaybe"));
        }
        [TestMethod]
        public void TestClientEat()
        {
            Assert.AreEqual(0, client.Eat(order));
        }
        [TestMethod]
        public void TestClientMakeOrder()
        {
            Assert.AreEqual(orderItem1, order.OrderItes[0]);
        }
        [TestMethod]
        public void TestOrderPay()
        {
            //payment for test order is 21.5
            Assert.AreEqual(21.5m, order.PaymentCalculation());
        }
        public void TestClientPay()
        {
            //check client money after payment
            client.Pay(order);
            Assert.AreEqual(178.5m, client.Money);
        }
        [TestMethod]
        public void TestOrderHungerCalculation()
        {
            //Total DecreaseHungerLevel for test order is 6
            Assert.AreEqual(6, order.HungerLevelCalculation());
        }
        [TestMethod]
        public void TestStandartRoomConstructor()
        {
            //standartRoom default  have 2 vacant tables
            foreach (Table table in standartRoom.Tables)
            {
                Assert.AreEqual(true, table.IsVacant);
            }
        }
        [TestMethod]
        public void TestStandartRoomChooseTable()
        {
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
        public void TestWaiterTakeOrder()
        {
            Assert.AreEqual(order, waiter.TakeOrder(order, 3));
        }
        [TestMethod]
        public void TestWaiterTakePayment()
        {
            //check waiter money after payment
            // at start waiter have 10$, then he take payment 100$
            waiter.TakePayment(100m, 3);
            Assert.AreEqual(110m, waiter.Money);
        }
        [TestMethod]
        public void TestAdminSayHelloAndAddSatisfactionToClient()
        {
            client.Satisfaction += admin.SayHelloAndAddSatisfaction();
            Assert.AreEqual(6, client.Satisfaction);
            Assert.AreEqual(1, admin.SayHelloAndAddSatisfaction());
        }
    }
}
