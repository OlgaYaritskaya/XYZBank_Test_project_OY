using OpenQA.Selenium;
using Sauce_demo.Data;
using Sauce_demo.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sauce_Demo.PageObjects
{
    public class LoginPageObject
    {
        static IWebDriver _driver;

        private readonly By _userNameInputLocator = By.CssSelector("[data-test='username']");
        private readonly By _passwordInputLocator = By.CssSelector("[data-test='password']");
        private readonly By _loginButtonLocator = By.CssSelector("[data-test='login-button']");

        public LoginPageObject(IWebDriver driver) 
        {
            _driver = driver;
        }

        public MainCataloguePageObject Login(Users.User userLogin)
        {
            var loginInput = _driver.FindElement(_userNameInputLocator);
            loginInput.SendKeys(userLogin.ToString());

            var PasswordInput = _driver.FindElement(_passwordInputLocator);
            PasswordInput.SendKeys("secret_sauce"); // подставить пароль из Users.GetPassword()

            _driver.FindElement(_loginButtonLocator).Click();

            return new MainCataloguePageObject(_driver);
        }




    }
}
