using System;

namespace TemplateMethod
{
    abstract class Builder
    {
        public void Build()
        {
            this.Test();
            this.Lint();
            this.Assemble();
            this.Deploy();
        }

        abstract public void Test();
        abstract public void Lint();
        abstract public void Assemble();
        abstract public void Deploy();
    }

    class AndroidBuilder : Builder
    {
        public override void Assemble()
        {
            Console.WriteLine("Assembling the Android build");
        }

        public override void Deploy()
        {
            Console.WriteLine("Deploying the Android build to server");
        }

        public override void Lint()
        {
            Console.WriteLine("Linting the Android code");
        }

        public override void Test()
        {
            Console.WriteLine("Running Android tests");
        }
    }

    class IosBuilder : Builder
    {
        public override void Assemble()
        {
            Console.WriteLine("Assembling the iOS build");
        }

        public override void Deploy()
        {
            Console.WriteLine("Deploying iOS build to server");
        }

        public override void Lint()
        {
            Console.WriteLine("Linting the iOS code");
        }

        public override void Test()
        {
            Console.WriteLine("Running iOS tests");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AndroidBuilder androidBuilder = new AndroidBuilder();
            androidBuilder.Build();

            IosBuilder iosBuilder = new IosBuilder();
            iosBuilder.Build();
        }
    }
}
