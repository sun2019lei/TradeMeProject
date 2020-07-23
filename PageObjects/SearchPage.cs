using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeMeGridAndUploadProject.PageObjects
{
    class SearchPage : PageObject
    //如果父类有构造函数，子类可以直接创建构造函数为了方便初始化，但是如果父类有构造函数，子类必须要调用父类的构造函数
    {
        private readonly IWebDriver Driver;


        public SearchPage(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
        }



        //public IWebElement TextBox1 => Driver.FindElement(By.XPath("//*[@id = 'email']"));
        //public IWebElement TextBox2 => Driver.FindElement(By.Name("password"));
        //public IWebElement LoginElement => Driver.FindElement(By.CssSelector("button[type ='submit']"));
        // public IWebElement Title => Driver.FindElements(By.XPath("//span[text()='sun'] "))[1];

        public void EnterForKeyWordSearch(string keyword)
        {

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("keywords")));

            var SearchBox1 = Driver.FindElement(By.XPath("//*[@name ='keywords']"));
            SearchBox1.Clear();
            SearchBox1.SendKeys(keyword);

        }

        public void SubmitForSearch()
        {
            SubmitButton.Click();
        }


        public void ByScrolDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            IWebElement element = Driver.FindElement(By.LinkText("Tester"));
            js.ExecuteScript("arguments[0].scrollIntoView();", element);

        }



        ////public IWebElement SearchBox1 => Driver.FindElement(By.XPath("//*[@name ='keywords']"));

        public IWebElement SubmitButton => Driver.FindElement(By.XPath("//*[@data-automation = 'searchButton']"));



    }
}
