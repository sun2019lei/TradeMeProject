using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TradeMeGridAndUploadProject.PageObjects
{
    class UploadPage : PageObject
    {
        private readonly IWebDriver Driver;
        public UploadPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public void ClickTheProfile()
        {
            Thread.Sleep(3000);
            ProfileButton.Click();

        }
        public void ClickTheAddResume()
        {
            Thread.Sleep(2000);
            TheAddResumeButton.Click();
            
        }

        public void ClickTheBrowse()
        {
            //TheBrowseButton.Click();
            Thread.Sleep(2000);
            string filePath = @"C:\Users\Sun Lei\Desktop\Test.txt";
            TheBrowseButton.SendKeys(filePath);

            //SendKeys.SendWait("C:\\Users\\Sun Lei\\Desktop");
            //SendKeys.SendWait("{Enter}");

        }




        public void ClickDoneButton()
        {
            DoneButton.Click();
        }


        public IWebElement DoneButton => Driver.FindElement(By.XPath(" //*[@data-automation ='manage-resume-done']"));


        public IWebElement TheBrowseButton => Driver.FindElement(By.XPath("//*[@data-automation ='resume-browse']"));

        public IWebElement TheAddResumeButton => Driver.FindElement(By.XPath("//*[@data-automation='resume-edit-link']"));

        public IWebElement ProfileButton => Driver.FindElement(By.LinkText("Profile"));
    }
}
