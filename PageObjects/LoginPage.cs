using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TradeMeGridAndUploadProject.PageObjects
{
    public class LoginPage : PageObject
    {
        private readonly IWebDriver Driver;


        //在C#中，派生类不能继承其基类的构造函数，但通过使用base关键字，派生类构造函数就可以调用基类的构造函数。
        public LoginPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }


        //public IWebElement TextBox1 => Driver.FindElement(By.XPath("//*[@id = 'email']"));
        //public IWebElement TextBox2 => Driver.FindElement(By.Name("password"));
        //public IWebElement LoginElement => Driver.FindElement(By.CssSelector("button[type ='submit']"));
        // public IWebElement Title => Driver.FindElements(By.XPath("//span[text()='sun'] "))[1];



        public void EnterForUserName(string username)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("email")));

            var TextBox1 = Driver.FindElement(By.XPath("//*[@id = 'email']"));
            TextBox1.Clear();
            TextBox1.SendKeys(username);
        }
        public void EnterForPassWord(string password)
        {
            var TextBox2 = Driver.FindElement(By.Name("password"));
            TextBox2.Clear();
            TextBox2.SendKeys(password);
        }
        public void LoginResult()
        {
            var LoginElement = Driver.FindElement(By.CssSelector("button[type ='submit']"));
            LoginElement.Click();
            Thread.Sleep(2000);
        }



    }
}
