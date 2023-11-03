//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace WebUITests
{
    public class SeleniumTest
    {
        [Fact]
        public void Test1()
        {
            //IWebDriver driver = new ChromeDriver();
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.starbucks.com");
            driver.Manage().Window.Maximize();
            var hamburgerMenu = driver.FindElement(By.LinkText("Find a store"));
            hamburgerMenu.Click();
            Thread.Sleep(500);
        }
    }
}