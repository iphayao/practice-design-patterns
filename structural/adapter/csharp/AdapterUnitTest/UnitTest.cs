using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adapter;

namespace AdapterUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCase()
        {
            // Expected result
            string expected = "woof woof";

            // Actual result
            WildDog dog = new WildDog();
            WildDogAdapter adapter = new WildDogAdapter(dog);

            Hunter hunter = new Hunter();
            string actual = hunter.hunt(adapter);

            // Test
            Assert.AreEqual(expected, actual);
        }
    }
}
