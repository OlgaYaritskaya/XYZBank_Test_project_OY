using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.DevTools.V119.Network;
using Sauce_Demo.PageObjects;
using static Sauce_demo.Data.Users;

namespace Sauce_demo.Tests
{
    public class Tests : BaseTest
    { 
        [Test]
        public void Test1()
        {

            LoginPageObject loginPage = new LoginPageObject(_driver);
            loginPage.Login(User.standard_user);
        }

    }
}