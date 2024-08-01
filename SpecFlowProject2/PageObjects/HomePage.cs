using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace SSRKCCAutomationProject.PageObjects
{
    public class HomePage
    {
        private readonly IWebDriver driver;

        [FindsBy(How = How.Id, Using = "menu-item-3111")]
        public IWebElement ContactLink { get; set; }


        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public void ClickContactLink()
        {
            ContactLink.Click();
            
        }

    }
}
