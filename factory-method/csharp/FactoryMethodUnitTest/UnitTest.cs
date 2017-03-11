using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryMethod;

namespace FactoryMethodUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCase()
        {
            // Expected Question
            string expectedDevMngQust = "Asking about design pattern!";
            string expectedMakMngQust = "Asking about community building!";

            // Actual Question
            string actualDevMngQust = "";
            string actualMakMngQust = "";

            // Create development manager for take interview with developer question
            DevelopmentManager devManager = new DevelopmentManager();
            actualDevMngQust = devManager.takeInterview();

            // Create maketing manager for take interview with community question
            MaketingManager markManager = new MaketingManager();
            actualMakMngQust = markManager.takeInterview();

            // Test for expected and actual value
            Assert.AreEqual(expectedDevMngQust, actualDevMngQust);
            Assert.AreEqual(expectedMakMngQust, actualMakMngQust);
        }
    }
}
