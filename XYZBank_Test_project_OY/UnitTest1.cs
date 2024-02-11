using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.DevTools.V119.Network;
using Sauce_Demo.PageObjects;
using static Sauce_demo.Data.Users;

namespace Sauce_Demo
{
    public class Tests
    {
        
        [SetUp]
        public static void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            IWebDriver _driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.google.com");
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            LoginPageObject loginPage = new LoginPageObject(_driver);
            loginPage.Login(User.standard_user);
        }

    }
}