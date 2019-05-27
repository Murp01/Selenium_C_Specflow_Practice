using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Tutorial.Tutorial_Tests
{
    
    class NavigationTest
    {
        IWebDriver driver;

        [SetUp]
        public void OpenWebApp()
        {
            driver = new FirefoxDriver();
            //driver.Url = "";
            driver.Navigate().GoToUrl("https://demoqa.com");
        }

        [Test]
        public void NavigateBackAndForward()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Sortable')]")).Click();
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().GoToUrl("https://demoqa.com");
            driver.Navigate().Refresh();
            //Github upload
            //Where be this comment
        }

        [TearDown]
        public void CloseTest()
        {
            driver.Close();
        }
    }
}
