using Intern.SetUP;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace Intern.TestCase
{
    public class Search : SetUp
    {
        [Test]
        public void SearchProduct()
        {
            driver.Navigate().GoToUrl(Constant.otherUrl);

            IWebElement search = driver.FindElement(By.XPath("//input[@type='search' and @placeholder='Search for Vegetables and Fruits' and @class='search-keyword']"));
            search.SendKeys("Brocolli - 1 Kg");

            Thread.Sleep(2000);

            IWebElement AddToCart = driver.FindElement(By.XPath("//button[text()='ADD TO CART' and @type='button']"));
            AddToCart.Click();

            IWebElement MyCart = driver.FindElement(By.XPath("//img[@src='https://rahulshettyacademy.com/seleniumPractise/images/bag.png' and @alt='Cart']"));
            MyCart.Click();

            Thread.Sleep(3000);

            IWebElement Procceed = driver.FindElement(By.XPath("//button[text()='PROCEED TO CHECKOUT' and @type='button']"));
            Procceed.Click();
            Thread.Sleep(3000);

            IWebElement PlaceOrder = driver.FindElement(By.XPath("//button[text()='Place Order']"));
            PlaceOrder.Click();
            Thread.Sleep(3000);

            var country1 = new SelectElement(driver.FindElement(By.XPath("//select[@style='width: 200px;']")));
            country1.SelectByValue("Albania");

            IWebElement checkbox3 = driver.FindElement(By.XPath("//input[@type='checkbox' and @class='chkAgree']"));
            checkbox3.Click();

            IWebElement Proceed2 = driver.FindElement(By.XPath("//button[text()='Proceed']"));
            Proceed2.Click();

            Thread.Sleep(5000);
        }
    }
}