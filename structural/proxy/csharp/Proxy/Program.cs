using System;

namespace Proxy
{
    interface IDoor
    {
        void Open();
        void Close();
    }

    class LabDoor : IDoor
    {
        public void Open()
        {
            Console.WriteLine("Opening lab door");
        }
        public void Close()
        {
            Console.WriteLine("Closing the lab door");
        }
    }
    class Security
    {
        protected IDoor door;

        public Security(IDoor door)
        {
            this.door = door;
        }
        public void Open(string password)
        {
            if(this.Atuthenticate(password)) 
            {
                this.door.Open();
            }
            else {
                Console.WriteLine("Big no! It ain't possible");
            }
        }

        public bool Atuthenticate(string password)
        {
            return password == "$ecr@t";
        }

        public void Close()
        {
            this.door.Close();
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Security door = new Security(new LabDoor());
            door.Open("invalid");
            door.Open("$ecr@t");            
            door.Close();
        }
    }
}
