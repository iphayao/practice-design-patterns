using System;

namespace FactoryMethod
{
    interface IInterviewer
    {
        void askQuestions();
    }

    class Developer : IInterviewer
    {
        public void askQuestions()
        {
            Console.WriteLine("Asking about design pattern!");
        }
    }

    class CommunityExecutive : IInterviewer
    {
        public void askQuestions()
        {
            Console.WriteLine("Asking about community building!");
        }
    }

    abstract class HiringManager
    {
        abstract public IInterviewer makeInterviewer();

        public void takeInterview()
        {
            IInterviewer interviewer = this.makeInterviewer();
            interviewer.askQuestions();
        }
    }

    class DevelopmentManager : HiringManager
    {
        public override IInterviewer makeInterviewer()
        {
            return new Developer();
        }
    }

    class MaketingManager : HiringManager
    {
        public override IInterviewer makeInterviewer()
        {
            return new CommunityExecutive();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DevelopmentManager devManager = new DevelopmentManager();
            devManager.takeInterview();

            MaketingManager markManager = new MaketingManager();
            markManager.takeInterview();
        }
    }
}