using System;

namespace Builder
{

    /// <summary>
    /// Create Burger class
    /// </summary>
    public class Burger
    {
        /// <summary>
        /// Private field of object
        /// </summary>
        private int size = 0;
        private bool cheese = false;
        private bool pepperoni = false;
        private bool lettuce = false;
        private bool tomato = false;

        /// <summary>
        /// Properties of object
        /// </summary>
        public int Size { get => size; private set => size = value; }
        public bool Cheese { get => cheese; private set => cheese = value; }
        public bool Pepperoni { get => pepperoni; private set => pepperoni = value; }
        public bool Lettuce { get => lettuce; private set => lettuce = value; }
        public bool Tomato { get => tomato; private set => tomato = value; }

        /// <summary>
        /// Constructor of Burger with BurgerBuilder parameter
        /// </summary>
        /// <param name="builder">the builder of burger</param>
        public Burger(BurgerBuilder builder)
        {
            this.size = builder.Size;
            this.cheese = builder.Cheese;
            this.pepperoni = builder.Pepperoni;
            this.lettuce = builder.Letture;
            this.tomato = builder.Tomato;
        }

    }


    /// <summary>
    /// The builder class
    /// </summary>
    public class BurgerBuilder
    {
        /// <summary>
        /// Private field of builder
        /// </summary>
        private int size = 0;
        private bool cheese = false;
        private bool pepperoni = false;
        private bool letture = false;
        private bool tomato = false;

        /// <summary>
        /// Properties of builder
        /// </summary>
        public int Size { get => size; private set => size = value; }
        public bool Cheese { get => cheese; private set => cheese = value; }
        public bool Pepperoni { get => pepperoni; private set => pepperoni = value; }
        public bool Letture { get => letture; private set => letture = value; }
        public bool Tomato { get => tomato; private set => tomato = value; }

        /// <summary>
        /// Constructor of builder with size value
        /// </summary>
        /// <param name="size"></param>
        public BurgerBuilder(int size)
        {
            this.size = size;
        }

        /// <summary>
        /// Enabled pepperoni field 
        /// </summary>
        /// <returns>builder</returns>
        public BurgerBuilder AddPepperoni()
        {
            this.pepperoni = true;
            return this;
        }

        /// <summary>
        /// Enabled letteur field
        /// </summary>
        /// <returns>builder</returns>
        public BurgerBuilder AddLettuce()
        {
            this.letture = true;
            return this;
        }

        /// <summary>
        /// Enabled cheese field
        /// </summary>
        /// <returns>builder</returns>
        public BurgerBuilder AddCheese()
        {
            this.cheese = true;
            return this;
        }

        /// <summary>
        /// Enabled tomato field
        /// </summary>
        /// <returns>builder</returns>
        public BurgerBuilder AddTomato()
        {
            this.tomato = true;
            return this;
        }

        /// <summary>
        /// Build burger object with builder fields (parameters)
        /// </summary>
        /// <returns>burger object</returns>
        public Burger Build()
        {
            return new Burger(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Burger burger = (new BurgerBuilder(14)).AddPepperoni()
                                                   .AddLettuce()
                                                   .AddTomato()
                                                   .Build();
        }
    }
}