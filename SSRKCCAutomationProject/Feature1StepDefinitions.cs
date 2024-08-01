using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using SSRKCCAutomationProject.PageObjects;

namespace SSRKCCAutomationProject
{
    [Binding]
    public class Feature1StepDefinitions
    {
        public IWebDriver driver;
        [Given(@"I am on the donate page")]
        public void GivenIAmOnTheDonatePage()
        {
            driver = new ChromeDriver();
            driver.Url = "https://krishnaofvrindavan.com/?page_id=2678";


        }

        [When(@"I fill in the standard details and click on the donate button")]
        public void WhenIFillInTheStandardDetailsAndClickOnTheDonateButton()
        {
            var donatepage = new DonatePage(driver);
            donatepage.EnterDetails("Rishi", "Bhandari", "grmhrj108@hotmail.com", "07736333201", "40");
            donatepage.ClickDonateButton();
        }

        [Then(@"Paypal page will load")]
        public void ThenPaypalPageWillLoad()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
