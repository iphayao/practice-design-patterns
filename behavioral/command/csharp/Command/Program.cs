using System;

namespace Command
{

    // Reciever
    class Bulb
    {
        public void TurnOn()
        {
            Console.WriteLine("Bulb has been it");
        }
        public void TurnOff()
        {
            Console.WriteLine("Darkness!");
        }
    }

    interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }

    // Command
    class TurnOn : ICommand
    {
        protected Bulb bulb;
        public TurnOn(Bulb bulb)
        {
            this.bulb = bulb;
        }
        public void Execute() 
        {
            this.bulb.TurnOn();
        }
        public void Undo() 
        {
            this.bulb.TurnOff();
        }
        public void Redo()
        {
            this.Execute();
        }

    }

    class TurnOff : ICommand
    {
        protected Bulb bulb;
        public TurnOff(Bulb bulb) 
        {
            this.bulb = bulb;
        }
        public void Execute()
        {
            this.bulb.TurnOff();
        }

        public void Redo()
        {
            this.bulb.TurnOn();
        }

        public void Undo()
        {
            this.Execute();
        }
    }

    // Invoker
    class RemoteControl
    {
        public void Submit(ICommand command) 
        {
            command.Execute();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Bulb bulb = new Bulb();
            TurnOn turnOn = new TurnOn(bulb);
            TurnOff turnOff = new TurnOff(bulb);

            RemoteControl remote = new RemoteControl();
            remote.Submit(turnOn);
            remote.Submit(turnOff);        }
    }
}
