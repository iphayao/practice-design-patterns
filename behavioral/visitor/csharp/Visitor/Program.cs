﻿using System;

namespace Visitor
{
    interface IAnimal
    {
        void Accept(IAnimalOperation operation);
    }

    interface IAnimalOperation
    {
        void VisitMonkey(Monkey monkey);
        void VisitLion(Lion lion);
        void VisitDolphin(Dolphin dolphin);
    }

    class Monkey : IAnimal
    {
        public void Shout()
        {
            Console.WriteLine("Ooh oo aa aa!");
        }
        public void Accept(IAnimalOperation operation)
        {
            operation.VisitMonkey(this);
        }
    }

    class Lion : IAnimal
    {
        public void Roar()
        {
            Console.WriteLine("Roaaar!");
        }
        public void Accept(IAnimalOperation operation)
        {
            operation.VisitLion(this);
        }
    }

    class Dolphin : IAnimal 
    {
        public void Speak()
        {
            Console.WriteLine("Tuut tuttu tuutt!");
        }
        public void Accept(IAnimalOperation operation)
        {
            operation.VisitDolphin(this);
        }
    }

    class Speak : IAnimalOperation
    {
        public void VisitDolphin(Dolphin dolphin)
        {
            dolphin.Speak();
        }

        public void VisitLion(Lion lion)
        {
            lion.Roar();
        }

        public void VisitMonkey(Monkey monkey)
        {
            monkey.Shout();
        }
    }

    class Jump : IAnimalOperation
    {
        public void VisitDolphin(Dolphin dolphin)
        {
            Console.WriteLine("Walked on water a little and disappeared");
        }

        public void VisitLion(Lion lion)
        {
            Console.WriteLine("Jumped 7 feet! Back on the ground!");
        }

        public void VisitMonkey(Monkey monkey)
        {
            Console.WriteLine("Jumped 20 feet high! on to the tree!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create all animal
            Monkey monkey = new Monkey();
            Lion lion = new Lion();
            Dolphin dolphin = new Dolphin();
            // Create speak and jump object
            Speak speak = new Speak();
            Jump jump = new Jump();
            // Accept for each animal type
            monkey.Accept(speak);
            monkey.Accept(jump);
            lion.Accept(speak);
            lion.Accept(jump);
            dolphin.Accept(speak);
            dolphin.Accept(jump);
        }
    }
}
