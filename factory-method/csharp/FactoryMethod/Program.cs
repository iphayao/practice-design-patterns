using System;

namespace FactoryMethod
{
    /// <summary>
    /// Interface for Interviewer
    /// </summary>
    public interface IInterviewer
    {
        string askQuestions();
    }


    /// <summary>
    /// Implement interviewer for Developer interview question
    /// </summary>
    class Developer : IInterviewer
    {
        public string askQuestions()
        {
            return "Asking about design pattern!";
        }
    }

    /// <summary>
    /// Inplement interviewer for Community Executive question
    /// </summary>
    class CommunityExecutive : IInterviewer
    {
        public string askQuestions()
        {
            return "Asking about community building!";
        }
    }

    /// <summary>
    /// Abstract class for Hiring Manager
    /// </summary>
    public abstract class HiringManager
    {
        abstract public IInterviewer makeInterviewer();

        public string takeInterview()
        {
            IInterviewer interviewer = this.makeInterviewer();
            return interviewer.askQuestions();
        }
    }

    /// <summary>
    /// Implement Development manager for ask about develper question
    /// </summary>
    public class DevelopmentManager : HiringManager
    {
        public override IInterviewer makeInterviewer()
        {
            return new Developer();
        }
    }

    /// <summary>
    /// Implement Maketing manager for ask about community question
    /// </summary>
    public class MaketingManager : HiringManager
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
            Console.WriteLine(devManager.takeInterview());

            // Create maketing manager for take interview with community question
            MaketingManager markManager = new MaketingManager();
            Console.WriteLine(markManager.takeInterview());
        }
    }
}