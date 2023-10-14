using Intern.SetUP;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace Intern.TestCase
{
    public class LogIn : SetUp
    {
        [Test]
        public void TestLogin()
        {

            //Driver i trasheguar nga klasa prind - test PR

            driver.Navigate().GoToUrl(Constant.BaseUrl);

            IWebElement username = driver.FindElement(By.XPath("//input[@type='text' and @name='username' and @id='username']"));
            username.SendKeys(Constant.Username);
            //By.CssSelector(#username)


            IWebElement Password = driver.FindElement(By.XPath("//input[@type='password' and @name='password' and @id='password']"));
            Password.SendKeys(Constant.Password);

            IWebElement Admin = driver.FindElement(By.XPath("//input[@type='radio' and @value='admin' and @id='usertype' and @name='radio' and @checked='checked']"));
            Admin.Click();

            var state = new SelectElement(driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div[5]/select")));
            state.SelectByValue("teach");

            //IWebDriver driver = new ChromeDriver();
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Implict wait
            Thread.Sleep(2000);

            IWebElement checkbox = driver.FindElement(By.CssSelector("#terms"));
            checkbox.Click();

            Thread.Sleep(3000);

            //  new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(
            //ExpectedConditions.ElementToBeClickable(By.CssSelector("#signInBtn"))).Click();
            //Explicit Wait

            IWebElement SingIn = driver.FindElement(By.CssSelector("#signInBtn"));
            SingIn.Click();
            Thread.Sleep(5000);
            IWebElement AddToCart = driver.FindElement(By.XPath("//button[@class='btn btn-info']"));
            AddToCart.Click();

            Thread.Sleep(3000);

            IWebElement checkout = driver.FindElement(By.XPath("//a[@class='nav-link btn btn-primary']"));
            checkout.Click();
            Thread.Sleep(3000);
            IWebElement checkout2 = driver.FindElement(By.XPath("//button[contains(@class, 'btn-success')]"));
            checkout2.Click();
            /////button[@class='btn btn-success' and @type='button']

            IWebElement Country = driver.FindElement(By.CssSelector("#country"));
            Country.SendKeys("Albania");
           Thread.Sleep(10000);
           IWebElement Alb = driver.FindElement(By.XPath("//*[contains(text(), 'Albania')]"));
           Alb.Click();

            Thread.Sleep(3000);
            IWebElement check2 = driver.FindElement(By.XPath("//label[@for='checkbox2']"));
            check2.Click();

            IWebElement Purchase = driver.FindElement(By.XPath("//input[@class='btn btn-success btn-lg' and @type='submit' and @value='Purchase']"));
            Purchase.Click();

            Thread.Sleep(5000);

        }
    }
}
