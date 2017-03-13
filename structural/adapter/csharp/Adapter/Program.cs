using System;

namespace Adapter
{
    public interface ILion
    {
        string roar();    
    }

    class AfricanLion : ILion
    {
        public string roar()
        {
            return "";
        }
    }

    class AsiaLion : ILion
    {
        public string roar()
        {
            return "";
        }
    }

    public class Hunter
    {
        public string hunt(ILion lion) 
        {
            return lion.roar();
        }
    }

    public class WildDog
    {
        public string bark() 
        {
            return "woof woof";
        }
    }

    public class WildDogAdapter : ILion
    {
        protected WildDog dog;

        public WildDogAdapter(WildDog dog)
        {
            this.dog = dog;
        }

        public string roar()
        {
            return this.dog.bark();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WildDog dog = new WildDog();
            WildDogAdapter adapter = new WildDogAdapter(dog);

            Hunter hunter = new Hunter();
            Console.WriteLine(hunter.hunt(adapter));
        }
    }
}
