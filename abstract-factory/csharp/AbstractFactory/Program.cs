using System;

namespace AbstractFactory
{
    /// <summary>
    /// Create Door interface
    /// </summary>
    public interface IDoor
    {
        string GetDescription();
    }

    /// <summary>
    /// Implement wooden door as door
    /// </summary>
    internal class WoodenDoor : IDoor
    {
        public string GetDescription()
        {
            return "I am a wooden door";
        }
    }

    /// <summary>
    /// Implement iron door as door
    /// </summary>
    internal class IronDoor : IDoor
    {
        public string GetDescription()
        {
            return "I am an iron door";
        }
    }

    /// <summary>
    /// Create door fitting expert interface
    /// </summary>
    public interface IDoorFittingExpert
    {
        string GetDescription();
    }

    /// <summary>
    /// Implement welder as door fitting expert
    /// </summary>
    internal class Welder : IDoorFittingExpert
    {
        public string GetDescription()
        {
            return "I can only fit iron doors";
        }
    }

    /// <summary>
    /// Implement Carpenter as door fitting expert
    /// </summary>
    internal class Carpenter : IDoorFittingExpert
    {
        public string GetDescription()
        {
            return "I can only fit wooden doors";
        }
    }

    /// <summary>
    /// Create door factory interface
    /// </summary>
    public interface IDoorFactory
    {
        IDoor MakeDoor();
        IDoorFittingExpert MakeFittingExpert();
    }

    /// <summary>
    /// Implement wooden door factory 
    /// </summary>
    public class WoodenDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new WoodenDoor();
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Carpenter();
        }
    }

    /// <summary>
    /// Implement iron door factory 
    /// </summary>
    public class IronDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new IronDoor();
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Welder();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDoor door;
            IDoorFittingExpert expert;

            // Create wooden factory object
            WoodenDoorFactory woodenFactory = new WoodenDoorFactory();

            // Make door and expert wooden factory
            door = woodenFactory.MakeDoor();
            expert = woodenFactory.MakeFittingExpert();

            // Get description of door and expert of wooden factory
            Console.WriteLine(door.GetDescription());
            Console.WriteLine(expert.GetDescription());

            // Crate iron factory object
            IronDoorFactory ironFactory = new IronDoorFactory();

            // Make door and expert iron factory
            door = ironFactory.MakeDoor();
            expert = ironFactory.MakeFittingExpert();

            // Get description of door and expert of iron facory
            Console.WriteLine(door.GetDescription());
            Console.WriteLine(expert.GetDescription());
             
        }
    }
}