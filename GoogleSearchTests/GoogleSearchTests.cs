using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoogleSearchTests
{
    public class GoogleSearchTests
    {
        [Test]
        public void TestGoogleSearch()
        {
            IWebDriver driver = new ChromeDriver("driverpath");
            driver.Navigate().GoToUrl("https://www.google.com");

            IWebElement e = driver.FindElement(By.CssSelector("input[name='q']"));

            e.SendKeys("Anchita");
            e.Submit();
        }
    }
}
