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
    public sealed class SearchStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly SearchPage page;

        private readonly IWebDriver driver;

        public SearchStep(IWebDriver driver)
        {
            this.driver = driver;
            page = new SearchPage(driver);

        }

        //[Given(@"user on (.*)")]
        //public void GivenUrl(string url)

        //{
        //    page.Navigate(url);
        //}


        [Given(@"I have entered (.*) into the textbox")]
        public void SearchTheKeyWord(string SearchData)
        {
            page.EnterForKeyWordSearch(SearchData);
        }



        [When(@"I press seek")]
        public void WhenIPressSeek()
        {
            page.SubmitForSearch();
        }


        [Then(@"the (.*) should be presented")]
        public void ShowFound(string ele)
        {
            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = '_3mgbOLD']")));
            var element = driver.FindElement(By.XPath("//*[@class = '_3mgbOLD']")).Text;
            Assert.AreEqual(ele, element);

        }
    }
}
