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
    }
}
