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

        private readonly By _cartButtonLocator = By.ClassName("shopping_cart_link");
        private readonly By _addToCartButtonLocator = By.CssSelector(".pricebar button");

        public MainCataloguePageObject(IWebDriver driver)
        {
            _driver = driver;   
        }

        public MainCataloguePageObject AddItemToCart()
        { 
            //добавить условие выбора, что выбираем.
            //не должно быть кнопки removeFromCart
            _driver.FindElement(_addToCartButtonLocator).Click();   

            return this;
        }

        public CartPageObject NavigateToCart()
        {
            _driver.FindElement(_cartButtonLocator).Click();

            return new CartPageObject(_driver);
        }

    }
}
