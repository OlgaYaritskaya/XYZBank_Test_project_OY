﻿using Sauce_Demo.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sauce_demo.Data.Users;

namespace Sauce_demo.Tests
{
    public class CartTests : BaseTest
    {
        [Test]
        public void CartIconShowsNumberOfAddedItems()
        {
            LoginPageObject loginPage = new LoginPageObject(_driver);
            
            //залогиниться
            var mainCatalogue = loginPage.Login(User.standard_user);
            
            //добавить товар в корзину


            //убедиться что у иконки появилось число

            //добавить еще товар

            //убедиться, что число изменилось
        }
    }
}
