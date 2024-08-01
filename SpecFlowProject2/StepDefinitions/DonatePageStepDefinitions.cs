using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using SSRKCCAutomationProject.PageObjects;


namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class DonatePageStepDefinitions
    {
        private IWebDriver driver;

        [Given(@"I am on the donate page")]
        public void GivenIAmOnTheDonatePage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://krishnaofvrindavan.com/?page_id=2678";
        }

        [When(@"I enter the standard details for Rishi Bhandari donation")]
        public void WhenIEnterTheStandardDetailsForRishiBhandariDonation()
        {


            var donatepage = new DonatePage(driver);
            donatepage.EnterDetails("Rishi", "Bhandari", "grmhrj108@hotmail.com", "07736333201", "40");
            donatepage.ClickDonateButton();

        }

        [Then(@"the paypal page loads")]
        public void ThenThePaypalPageLoads()
        {
            throw new PendingStepException();
        }
    }
}
