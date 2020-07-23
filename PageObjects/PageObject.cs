using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeMeGridAndUploadProject.PageObjects
{
    public abstract class PageObject

    {
        private readonly IWebDriver Driver;

        public PageObject(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public void Navigate(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

    }
}
