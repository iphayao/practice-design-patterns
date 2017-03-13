using System;

namespace Singleton
{
    public class President
    {
        private static President instance = null;

        public President()
        {
            // Hide the constructor
        }

        public static President GetInstance()
        {
            if(instance != null)
            {
                instance = new President();
            }
            return instance;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            President president1 = President.GetInstance();
            President president2 = President.GetInstance();

            if(Object.ReferenceEquals(president1, president2)) {
                Console.WriteLine("Same object");
            }
        }
    }
}
