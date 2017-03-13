using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prototype;

namespace PrototypeUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCase()
        {
            // Setup default variable
            string originalName = "Jolly";
            string clonedName = "Dolly";
            string defaultCategory = "Mountain Sheep";

            // Expected result
            string expOriginalName = originalName;
            string expClonedName = clonedName;
            string expCategory = defaultCategory;

            // Actual result

            Sheep original = new Sheep("Jolly");
            string actOriginalName = original.GetName();
            string actOriginalCategory = original.GetCategory();
            
            // Clone and modify what require.
            Sheep cloned = original.Clone();
            cloned.SetName("Dolly");
            string actClonedName = cloned.GetName();
            string actClonedCategory = cloned.GetCategory();

            // Test
            Assert.AreEqual(expOriginalName, actOriginalName);
            Assert.AreEqual(expCategory, actOriginalCategory);
            Assert.AreEqual(expClonedName, actClonedName);
            Assert.AreEqual(expCategory, actClonedCategory);

        }
    }
}
