using System;

namespace FactoryMethod
{
    /// <summary>
    /// Interface for Interviewer
    /// </summary>
    interface IInterviewer
    {
        void askQuestions();
    }


    /// <summary>
    /// Implement interviewer for Developer interview question
    /// </summary>
    class Developer : IInterviewer
    {
        public void askQuestions()
        {
            Console.WriteLine("Asking about design pattern!");
        }
    }

    /// <summary>
    /// Inplement interviewer for Community Executive question
    /// </summary>
    class CommunityExecutive : IInterviewer
    {
        public void askQuestions()
        {
            Console.WriteLine("Asking about community building!");
        }
    }

    /// <summary>
    /// Abstract class for Hiring Manager
    /// </summary>
    abstract class HiringManager
    {
        abstract public IInterviewer makeInterviewer();

        public void takeInterview()
        {
            IInterviewer interviewer = this.makeInterviewer();
            interviewer.askQuestions();
        }
    }

    /// <summary>
    /// Implement Development manager for ask about develper question
    /// </summary>
    class DevelopmentManager : HiringManager
    {
        public override IInterviewer makeInterviewer()
        {
            return new Developer();
        }
    }

    /// <summary>
    /// Implement Maketing manager for ask about community question
    /// </summary>
    class MaketingManager : HiringManager
    {
        public override IInterviewer makeInterviewer()
        {
            return new CommunityExecutive();
        }
    }

    /// <summary>
    /// Factory Method:
    /// "It provided a way to delegated the implementation logic to child classes."
    /// 
    /// When to use?
    /// Usefull when there is some generic processing in class but require sub-class in dynamically
    /// decided at runtim or putting it in other words, when client doesn't know what exact sub-class is might need.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create development manager for take interview with developer question
            DevelopmentManager devManager = new DevelopmentManager();
            devManager.takeInterview();

            // Create maketing manager for take interview with community question
            MaketingManager markManager = new MaketingManager();
            markManager.takeInterview();
        }
    }
}