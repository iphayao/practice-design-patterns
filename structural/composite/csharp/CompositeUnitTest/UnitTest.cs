using Microsoft.VisualStudio.TestTools.UnitTesting;
using Composite;

namespace CompositeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase()
        {
            // Expected result
            double exptTotalSalary = 300;

            // Actual result;
            Developer john = new Developer("John Doe", 100);
            Designer jane = new Designer("Jane", 200);

            Organization org = new Organization();
            org.addEmployee(john);
            org.addEmployee(jane);

            double actTotalSalary = org.getNetSalary();

            // TestCase
            Assert.AreEqual(exptTotalSalary, actTotalSalary);
        }
    }
}
