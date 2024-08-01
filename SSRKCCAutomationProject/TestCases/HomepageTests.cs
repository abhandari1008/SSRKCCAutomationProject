using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using SSRKCCAutomationProject.PageObjects;
using SeleniumExtras.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace SSRKCCAutomationProject.TestCases
{
    [TestClass]
    public class HomepageTests
    {
        [TestMethod]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
        driver.Url = "https://www.krishnaofvrindavan.com";


            driver.FindElement(By.Id("text")).Click();
            

            var homePage = new HomePage(driver);
            homePage.ClickContactLink();
       


            }
    }
}
