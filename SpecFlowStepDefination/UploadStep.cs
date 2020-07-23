using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TradeMeGridAndUploadProject.PageObjects;

namespace TradeMeGridAndUploadProject.SpecFlowStepDefination
{
    [Binding]
    public sealed class UploadStep
    {
        private readonly UploadPage page;

        private readonly IWebDriver driver;

        public UploadStep(IWebDriver driver)
        {
            this.driver = driver;
            page = new UploadPage(driver);

        }


        [When(@"I click the Profile")]
        public void ClickProfile()
        {
            page.ClickTheProfile();
        }

        [When(@"I click the Add and Manage Resume")]
        public void ClickAddManageResume()
        {
            page.ClickTheAddResume();
        }
        [When(@"I click the Browse")]
        public void ClickTheBrowse()
        {
            page.ClickTheBrowse();
        }


        [Then(@"I click the Done")]
        public void ClickTheDone()
        {
            page.ClickDoneButton();
        }

    }
}
