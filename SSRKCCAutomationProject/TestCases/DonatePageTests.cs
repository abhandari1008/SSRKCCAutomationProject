using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSRKCCAutomationProject.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SSRKCCAutomationProject.TestCases
{
    [TestClass]
    public class DonatePageTests
    {

        
        [TestMethod]
        public void TestOne()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://krishnaofvrindavan.com/?page_id=2678";

            var donatepage = new DonatePage(driver);
            donatepage.EnterDetails("Rishi", "Bhandari", "grmhrj108@hotmail.com", "07736333201", "40");
            donatepage.ClickDonateButton();


        }
    }
}
