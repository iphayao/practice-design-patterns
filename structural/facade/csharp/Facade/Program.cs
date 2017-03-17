using System;

namespace Facade
{
    public class Computer
    {
        public string GetElectricShock()
        {
            return "Ouch!";
        }
        public string MakeSound()
        {
            return "Beep beep!";
        }
        public string ShowLoadingScreen()
        {
            return "Loading...";
        }
        public string Bam()
        {
            return "Ready to be used!";
        }
        public string CloseEverything()
        {
            return "Bup bup bup buzzzz!";
        }
        public string Sooth()
        {
            return "Zzzzz";
        }
        public string PullCurrent()
        {
            return "Haaah!";
        }
    }

    public class ComputerFacade
    {
        protected Computer computer;

        public ComputerFacade(Computer computer)
        {
            this.computer = computer;
        }

        public void TurnOn() 
        {
            Console.WriteLine(this.computer.GetElectricShock());
            Console.WriteLine(this.computer.MakeSound());
            Console.WriteLine(this.computer.ShowLoadingScreen());
            Console.WriteLine(this.computer.Bam());
        }

        public void TurnOff()
        {
            Console.WriteLine(this.computer.CloseEverything());
            Console.WriteLine(this.computer.PullCurrent());
            Console.WriteLine(this.computer.Sooth());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ComputerFacade computer = new ComputerFacade(new Computer());
            computer.TurnOn();
            computer.TurnOff();
        }
    }
}
