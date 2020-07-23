using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TradeMeGridAndUploadProject.PageObjects;

namespace TradeMeGridAndUploadProject.SpecFlowStepDefination
{
    [Binding]
    public sealed class LoginStep 
    {
        private readonly LoginPage page;

        private readonly IWebDriver _driver;

        public LoginStep(IWebDriver driver)
        {
            _driver = driver;
            page = new LoginPage(driver);
        }

        //[Given(@"user on the (.*) page")]
        //public void InputUrl(string url)
        //{
        //    page.Navigate(url);
        //}

        //[When(@"I typed the (.*)")]
        //public void TypeUserName(string username)
        //{
        //    page.EnterForUserName(username);
        //}



        //[When(@"I entered the (.*)")]
        //public void EnterPassword(string password)
        //{
        //    page.EnterForPassWord(password);
        //}

        //[When(@"Login button")]
        //public void WhenLoginButton()
        //{
        //    page.LoginResult();
        //}

        [Then(@"The title (.*) was presented after login")]
        public void PresentTitle(string title)
        {
            // Why add a hard-coded sleep here? 
            // How to proper wait for an element to appear?

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@data-automation='user-account-name']")));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("sun")]");
            var actualTitle = _driver.FindElement(By.XPath("//span[@data-automation='user-account-name']")).Text;
            Assert.AreEqual(title, actualTitle);
        }
    }
}
