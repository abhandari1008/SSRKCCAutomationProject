using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace SSRKCCAutomationProject.PageObjects
{
    public class DonatePage
    {
        private readonly IWebDriver driver;

        [FindsBy(How = How.Id, Using = "evf-2781-field_YGFoZenVgq-1")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "evf-2781-field_cgrgWBfgeE-5")]
        public IWebElement Surname { get; set; }

        [FindsBy(How = How.Id, Using = "evf-2781-field_Ei76iNp1kQ-2")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "evf-2781-field_q4yQUpYSWG-12")]
        public IWebElement Phone { get; set; }

        [FindsBy(How = How.Id, Using = "evf-2781-field_ftgavRVAZY-13")]
        public IWebElement Amount { get; set; }


        [FindsBy(How = How.Name, Using = "everest_forms[submit]")]
        public IWebElement Donate { get; set; }

        public DonatePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public void EnterDetails(string firstName, string surname, string email, string phone, string amount)
        {
            FirstName.SendKeys(firstName);
            Surname.SendKeys(surname);
            Email.SendKeys(email);  
            Phone.SendKeys(phone);
            Amount.SendKeys(amount);


        }

        public void ClickDonateButton()
        {
            Donate.Click();
        }

        public void CheckErrorMessages()
        {

        }
    }
}
