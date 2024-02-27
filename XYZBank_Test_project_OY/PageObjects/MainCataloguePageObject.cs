using NUnit.Framework.Internal;
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
        private readonly By _removeItemFromCartButtonLocator = By.XPath("//button[contains(text(), 'Remove')]");

        public MainCataloguePageObject(IWebDriver driver)
        {
            _driver = driver;   
        }

        public MainCataloguePageObject AddItemToCart(string itemName)
        { 
            var updatedItemName = itemName.ToLower().Replace(" ", "-");
            _driver.FindElement(By.Id($"add-to-cart-{updatedItemName}")).Click();

            return this;
        }

        public MainCataloguePageObject RemoveItemFromCart(string itemName)
        {
            var updatedItemName = itemName.ToLower().Replace(" ", "-");
            _driver.FindElement(By.Id($"remove-{updatedItemName}")).Click();

            return this;
        }
        public CartPageObject NavigateToCart()
        {
            _driver.FindElement(_cartButtonLocator).Click();

            return new CartPageObject(_driver);
        }

    }
}
