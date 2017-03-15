using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;

namespace BridgeUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCase()
        {
            // Exptected result

            string expContentAboutDarkTheme = "About page in Dark Black";
            string expContentCareersLightTheme = "Careers page in Off White";

            // Actual result
            DarkTheme darkTheme = new DarkTheme();
            LightTheme lightTheme = new LightTheme();

            About about = new About(darkTheme);
            Careers careers = new Careers(lightTheme);

            string actContentAboutDarkThem = about.getContent();
            string actContentCareersLightTheme  = careers.getContent();

            // Test
            Assert.AreEqual(expContentAboutDarkTheme, actContentAboutDarkThem);
            Assert.AreEqual(expContentCareersLightTheme, actContentCareersLightTheme);
        }
    }
}
