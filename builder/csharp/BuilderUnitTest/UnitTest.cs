using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Builder;

namespace BuilderUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCase1()
        {
            int size = 10;
            // Expected result
            int expSize = size;
            bool expCheese = true;
            bool expPepperoni = true;
            bool expLetture = true;
            bool expTomato = true;

            // Actual result
            Burger burgerTest = (new BurgerBuilder(size)).AddPepperoni()
                                                         .AddCheese()
                                                         .AddLettuce()
                                                         .AddTomato()
                                                         .Build();
            int actSize = burgerTest.Size;
            bool actCheese = burgerTest.Cheese;
            bool actPepperoni = burgerTest.Pepperoni;
            bool actLetture = burgerTest.Lettuce;
            bool actTomato = burgerTest.Tomato;

            // Test
            Assert.AreEqual(expSize, actSize);
            Assert.AreEqual(expCheese, actCheese);
            Assert.AreEqual(expPepperoni, actPepperoni);
            Assert.AreEqual(expLetture, actLetture);
            Assert.AreEqual(expTomato, actTomato);
        }

        [TestMethod]
        public void TestCase2()
        {
            int size = 20;
            // Expected result
            int expSize = size;
            bool expCheese = false;
            bool expPepperoni = false;
            bool expLetture = false;
            bool expTomato = false;

            // Actual result
            Burger burgerTest = (new BurgerBuilder(size)).Build();

            int actSize = burgerTest.Size;
            bool actCheese = burgerTest.Cheese;
            bool actPepperoni = burgerTest.Pepperoni;
            bool actLetture = burgerTest.Lettuce;
            bool actTomato = burgerTest.Tomato;

            // Test
            Assert.AreEqual(expSize, actSize);
            Assert.AreEqual(expCheese, actCheese);
            Assert.AreEqual(expPepperoni, actPepperoni);
            Assert.AreEqual(expLetture, actLetture);
            Assert.AreEqual(expTomato, actTomato);
        }

        [TestMethod]
        public void TestCase3()
        {
            int size = 20;
            // Expected result
            int expSize = size;
            bool expCheese = false;
            bool expPepperoni = true;
            bool expLetture = true;
            bool expTomato = true;

            // Actual result
            Burger burgerTest = (new BurgerBuilder(size)).AddPepperoni()
                                                         .AddLettuce()
                                                         .AddTomato()
                                                         .Build();

            int actSize = burgerTest.Size;
            bool actCheese = burgerTest.Cheese;
            bool actPepperoni = burgerTest.Pepperoni;
            bool actLetture = burgerTest.Lettuce;
            bool actTomato = burgerTest.Tomato;

            // Test
            Assert.AreEqual(expSize, actSize);
            Assert.AreEqual(expCheese, actCheese);
            Assert.AreEqual(expPepperoni, actPepperoni);
            Assert.AreEqual(expLetture, actLetture);
            Assert.AreEqual(expTomato, actTomato);
        }

        [TestMethod]
        public void TestCase4()
        {
            int size = 10;
            // Expected result
            int expSize = size;
            bool expCheese = true;
            bool expPepperoni = true;
            bool expLetture = true;
            bool expTomato = false;

            // Actual result
            Burger burgerTest = (new BurgerBuilder(size)).AddPepperoni()
                                                         .AddCheese()
                                                         .AddLettuce()
                                                         .Build();
            int actSize = burgerTest.Size;
            bool actCheese = burgerTest.Cheese;
            bool actPepperoni = burgerTest.Pepperoni;
            bool actLetture = burgerTest.Lettuce;
            bool actTomato = burgerTest.Tomato;

            // Test
            Assert.AreEqual(expSize, actSize);
            Assert.AreEqual(expCheese, actCheese);
            Assert.AreEqual(expPepperoni, actPepperoni);
            Assert.AreEqual(expLetture, actLetture);
            Assert.AreEqual(expTomato, actTomato);
        }

        [TestMethod]
        public void TestCase5()
        {
            int size = 10;
            // Expected result
            int expSize = size;
            bool expCheese = true;
            bool expPepperoni = false;
            bool expLetture = true;
            bool expTomato = true;

            // Actual result
            Burger burgerTest = (new BurgerBuilder(size)).AddCheese()
                                                         .AddLettuce()
                                                         .AddTomato()
                                                         .Build();
            int actSize = burgerTest.Size;
            bool actCheese = burgerTest.Cheese;
            bool actPepperoni = burgerTest.Pepperoni;
            bool actLetture = burgerTest.Lettuce;
            bool actTomato = burgerTest.Tomato;

            // Test
            Assert.AreEqual(expSize, actSize);
            Assert.AreEqual(expCheese, actCheese);
            Assert.AreEqual(expPepperoni, actPepperoni);
            Assert.AreEqual(expLetture, actLetture);
            Assert.AreEqual(expTomato, actTomato);
        }


    }
}
