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
    public sealed class CommonStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly LoginPage page;


        //private readonly IWebDriver driver;

        public CommonStep(IWebDriver driver)
        {

            
            page = new LoginPage(driver);

        }

        [Given(@"user on the (.*) page")]
        public void InputUrl(string url)
        {
            page.Navigate(url);
        }

        [When(@"I typed the (.*)")]
        public void TypeUserName(string username)
        {
            page.EnterForUserName(username);
        }

        [When(@"I entered the (.*)")]
        public void EnterPassword(string password)
        {
            page.EnterForPassWord(password);
        }

        [When(@"Login button")]
        public void WhenLoginButton()
        {
            page.LoginResult();
        }
    }
}
