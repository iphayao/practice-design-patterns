using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decorator;

namespace DecoratorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            // Expected Result
            int expSimpleCoffeeCost = 10;
            int expMilkCoffeeCost = expSimpleCoffeeCost + 2;
            int expWhipCoffeeCost = expSimpleCoffeeCost + 5;
            int expVanillaCoffeeCost = expSimpleCoffeeCost + 3;

            string expSimpleCoffeeDesc = "Simple coffee";
            string expMilkCoffeeDesc = expSimpleCoffeeDesc + ", milk";
            string expWhipCoffeeDesc = expSimpleCoffeeDesc + ", whip";
            string expVanillaCoffeeDesc = expSimpleCoffeeDesc + ", vanilla";

            // Actual Result
            int actSimpleCoffeeCost = 0;
            int actMilkCoffeeCost = 0;
            int actWhipCoffeeCost = 0;
            int actVanillaCoffeeCost = 0;

            string actSimpleCoffeeDesc = string.Empty;
            string actMilkCoffeeDesc = string.Empty;
            string actWhipCoffeeDesc = string.Empty;
            string actVanillaCoffeeDesc = string.Empty;

            SimpleCoffee simple = new SimpleCoffee();
            actSimpleCoffeeCost = simple.getCost();
            actSimpleCoffeeDesc = simple.getDescription();

            MilkCoffee milkCoffee = new MilkCoffee(simple);
            actMilkCoffeeCost = milkCoffee.getCost();
            actMilkCoffeeDesc = milkCoffee.getDescription();

            WhipCoffee whipCoffee = new WhipCoffee(simple);
            actWhipCoffeeCost = whipCoffee.getCost();
            actWhipCoffeeDesc = whipCoffee.getDescription();

            VanillaCoffee vanillaCoffee = new VanillaCoffee(simple);
            actVanillaCoffeeCost = vanillaCoffee.getCost();
            actVanillaCoffeeDesc = vanillaCoffee.getDescription();
            // Test
            Assert.AreEqual(expSimpleCoffeeCost, actSimpleCoffeeCost);
            Assert.AreEqual(expMilkCoffeeCost, actMilkCoffeeCost);
            Assert.AreEqual(expWhipCoffeeCost, actWhipCoffeeCost);
            Assert.AreEqual(expVanillaCoffeeCost, actVanillaCoffeeCost);

            Assert.AreEqual(expSimpleCoffeeDesc, actSimpleCoffeeDesc);
            Assert.AreEqual(expMilkCoffeeDesc, actMilkCoffeeDesc);
            Assert.AreEqual(expWhipCoffeeDesc, actWhipCoffeeDesc);
            Assert.AreEqual(expVanillaCoffeeDesc, actVanillaCoffeeDesc);

        }
    }
}
