using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace SingletonUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCase()
        {
            // Expected result
            President expPresident = President.GetInstance();

            // Actual result
            President actPresident = President.GetInstance();

            // Test
            Assert.AreEqual(expPresident, actPresident);

        }
    }
}
