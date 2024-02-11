using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sauce_demo.PageObjects
{
    public class CartPageObject
    {
        private readonly By _removeButtonLocator = By.Id("remove-sauce-labs-backpack");
        private readonly By _cartItemLocator = By.ClassName(".cart_item");
        private readonly By _checkOutButtonLocator = By.Id("checkout");
        private readonly By _continueShoppingButtonLocator = By.Id("continue-shopping");


        IWebDriver _driver;
        public CartPageObject(IWebDriver driver) 
        {
            _driver = driver;   
        }


    }
}
