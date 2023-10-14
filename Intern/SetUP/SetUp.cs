using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Intern.SetUP
{
    
    public class SetUp
    {
        public IWebDriver driver;

        [SetUp]
        public void inicialisize()
        {
            string browserType = "Chrome";
            driver = InicializimiBrowser(browserType);
            if (Constant.MaximizePage)
            {
                driver.Manage().Window.Maximize();
            }
        }

        private IWebDriver InicializimiBrowser(string browserType)
        {
            if(browserType.Equals("Chrome",StringComparison.OrdinalIgnoreCase))
            {
                driver = new ChromeDriver();
            }
             else if (browserType.Equals("Edge", StringComparison.OrdinalIgnoreCase))
            {
                driver = new EdgeDriver();
            }
            else
            {
                throw new ArgumentException("Nuk ke vendosur driver te sakte");
            }
            return driver;
        }
        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
