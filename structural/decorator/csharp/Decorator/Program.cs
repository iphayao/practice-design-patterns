using System;

namespace Decorator
{
    public interface ICoffee
    {
        int getCost();
        string getDescription();
    }

    public class SimpleCoffee : ICoffee
    {
        public int getCost()
        {
            return 10;
        }

        public string getDescription()
        {
            return "Simple coffee";
        }
    }

    public class MilkCoffee : ICoffee
    {
        protected ICoffee coffee;

        public MilkCoffee(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public int getCost()
        {
            return this.coffee.getCost() + 2;
        }

        public string getDescription()
        {
            return this.coffee.getDescription() + ", milk";
        }
    }

    public class WhipCoffee : ICoffee
    {
        protected ICoffee coffee;

        public WhipCoffee(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public int getCost()
        {
            return this.coffee.getCost() + 5;
        }

        public string getDescription()
        {
            return this.coffee.getDescription() + ", whip";
        }
    }    

    public class VanillaCoffee : ICoffee
    {
        protected ICoffee coffee;

        public VanillaCoffee(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public int getCost()
        {
            return this.coffee.getCost() + 3;
        }

        public string getDescription()
        {
            return this.coffee.getDescription() + ", vanilla";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCoffee simple = new SimpleCoffee();
            Console.WriteLine(simple.getCost());
            Console.WriteLine(simple.getDescription());

            MilkCoffee milkCoffee = new MilkCoffee(simple);
            Console.WriteLine(milkCoffee.getCost());
            Console.WriteLine(milkCoffee.getDescription());

            WhipCoffee whipCoffee = new WhipCoffee(simple);
            Console.WriteLine(whipCoffee.getCost());
            Console.WriteLine(whipCoffee.getDescription());

            VanillaCoffee vanillaCoffee = new VanillaCoffee(simple);
            Console.WriteLine(whipCoffee.getCost());
            Console.WriteLine(whipCoffee.getDescription());
        }
    }
}
