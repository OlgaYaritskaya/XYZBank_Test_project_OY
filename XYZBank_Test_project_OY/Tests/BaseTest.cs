using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sauce_demo.Tests //неймспейс для тестов нужен отдельный?
{
    public class BaseTest
    {
        protected static IWebDriver _driver; //какие модификаторы тут нужны

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [TearDown]  
        public void TearDown() 
        { 
            _driver.Close();
        }


    }
}
