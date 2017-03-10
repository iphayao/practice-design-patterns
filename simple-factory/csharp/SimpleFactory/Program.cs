using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// Interface of door
    /// </summary>
    interface IDoor
    {
        float getWidth();
        float getHeight();
    }

    /// <summary>
    /// Implementation class of door interface
    /// </summary>
    class WoodenDoor : IDoor
    {
        protected float width;
        protected float height;

        /// <summary>
        /// Constructor of implementation of door interface
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public WoodenDoor(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Get method of width value of door
        /// </summary>
        /// <returns>The width value of door</returns>
        public float getWidth()
        {
            return width;
        }

        /// <summary>
        /// Get method of height value of door
        /// </summary>
        /// <returns>The height value of door</returns>
        public float getHeight()
        {
            return height;
        }
    }

    /// <summary>
    /// Door factory class
    /// </summary>
    class DoorFacory
    {
        /// <summary>
        /// Factory method that return implementation of door interface
        /// </summary>
        /// <param name="width">The width of door</param>
        /// <param name="height">The height of door</param>
        /// <returns>The door instance (WoodenDoor)</returns>
        public static IDoor makeDoor(float width, float height)
        {
            return new WoodenDoor(width, height);
        }
    }


    class Program
    {
        /// <summary>
        /// Enter method of program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Create door instance by calls makeDoor method of DoorFactory
            // with width/height value as input
            var door = DoorFacory.makeDoor(100, 200);
            // Display Widht/Height of door instance to screen
            Console.WriteLine("Width: {0}", door.getWidth());
            Console.WriteLine("Height: {0}", door.getHeight());
        }
    }
}
