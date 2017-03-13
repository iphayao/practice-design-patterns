using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleFactory;

namespace SimpleFactoryUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCase()
        {
            // Epected result
            float expectedWidth = 200;
            float expectHeight = 100;
            // Actual result
            float actualWidth = 0;
            float actualHeight = 0;

            // Create object for test
            var door = DoorFacory.makeDoor(expectedWidth, expectHeight);

            // Get actual value
            actualWidth = door.getWidth();
            actualHeight = door.getHeight();

            // Assert type and value
            Assert.AreEqual(typeof(WoodenDoor), door.GetType());
            Assert.AreEqual(expectedWidth, actualWidth);
            Assert.AreEqual(expectHeight, actualHeight);
        }
    }
}
