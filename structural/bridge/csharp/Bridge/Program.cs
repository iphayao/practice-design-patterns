using System;

namespace Bridge
{
    interface IWebpage
    {
        string getContent();
    }

    public class About : IWebpage 
    {
        protected ITheme theme;

        public About(ITheme theme)
        {
            this.theme = theme;
        }

        public string getContent() 
        {
            return "About page in " + this.theme.getColor();
        }
    }

    public class Careers : IWebpage
    {
        protected ITheme theme;

        public Careers(ITheme theme) 
        {
            this.theme = theme;
        }

        public string getContent()
        {
            return "Careers page in " + this.theme.getColor();
        }
    }

    public interface ITheme 
    {
        string getColor();
    }

    public class DarkTheme : ITheme
    {
        public string getColor()
        {
            return "Dark Black";
        }
    }

    public class LightTheme : ITheme
    {
        public string getColor()
        {
            return "Off White";
        }
    }

    public class AquaTheme : ITheme 
    {
        public string getColor()
        {
            return "Light blue";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            DarkTheme darkTheme = new DarkTheme();
            LightTheme lightTheme = new LightTheme();

            About about = new About(darkTheme);
            Careers careers = new Careers(lightTheme);

            Console.WriteLine(about.getContent());
            Console.WriteLine(careers.getContent());
        }
    }
}
