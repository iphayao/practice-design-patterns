using System;

namespace Prototype
{
    public class Sheep 
    {
        public string name;
        public string category = null;
        public Sheep(string name, string category = "Mountain Sheep")
        {
            this.name = name;
            this.category = category;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetCategory(string category)
        {
            this.category = category;
        }
        public string GetCategory()
        {
            return this.category;
        }

        public Sheep Clone() 
        {
            return (Sheep)this.MemberwiseClone();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Sheep original = new Sheep("Jolly");
            Console.WriteLine(original.GetName());
            Console.WriteLine(original.GetCategory());
            // Clone and modify what require.
            Sheep cloned = original.Clone();
            cloned.SetName("Dolly");
            Console.WriteLine(cloned.GetName());
            Console.WriteLine(cloned.GetCategory());
        }
    }
}
