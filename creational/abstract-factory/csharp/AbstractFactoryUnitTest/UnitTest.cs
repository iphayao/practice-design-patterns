using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactory;

namespace AbstractFactoryUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCase1()
        {
            // Expected result
            string expWoodenDoorDes = "I am a wooden door";
            string expWoodenEpxertDes = "I can only fit wooden doors";

            // Actual result
            WoodenDoorFactory woodenFactory = new WoodenDoorFactory();

            string actWoodenDoorDes = woodenFactory.MakeDoor().GetDescription();
            string actWoodenExpertDes = woodenFactory.MakeFittingExpert().GetDescription();

            // Test
            // for Wooden door factory
            Assert.AreEqual(expWoodenDoorDes, actWoodenDoorDes);
            Assert.AreEqual(expWoodenEpxertDes, actWoodenExpertDes);
        }

        [TestMethod]
        public void TestCase2()
        {
            // Expected result
            string expIronDoorDes = "I am an iron door";
            string expIronExpertDes = "I can only fit iron doors";

            // Actual result
            IronDoorFactory ironFactory = new IronDoorFactory();

            string actIronDoorDes = ironFactory.MakeDoor().GetDescription();
            string actIronExpertDes = ironFactory.MakeFittingExpert().GetDescription();

            // Test
            // for Iron door factory
            Assert.AreEqual(expIronDoorDes, actIronDoorDes);
            Assert.AreEqual(expIronExpertDes, actIronExpertDes);
        }
    }
}
