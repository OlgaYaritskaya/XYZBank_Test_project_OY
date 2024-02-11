using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sauce_demo.PageObjects
{
    public class MainCataloguePageObject
    {
        IWebDriver _driver;

        public MainCataloguePageObject(IWebDriver driver)
        {
            _driver = driver;   
        }
    }
}
