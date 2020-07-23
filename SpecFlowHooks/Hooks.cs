using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TradeMeGridAndUploadProject.WebDriverFactory;

namespace TradeMeGridAndUploadProject.SpecFlowHooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;
        private static WebDriverFactories _driverFactory;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario

            //_driverFactory = new WebDriverFactories();
            //_driver = _driverFactory.Create(BrowserType.Chrome);

            String nodeUrl = "http://192.168.56.1:20459/wd/hub";
            //ChromeOptions options = new ChromeOptions();

            //options.setCapability("browserName", "chrome");
            //options.setCapability("platform", "WINDOWS");
            //DesiredCapabilities capability = new DesiredCapabilities();
            //capability.SetCapability("browsername", "firefox");
            
            //capability.SetCapability("platform","Windows 10");

            //_driver = new RemoteWebDriver(new Uri(nodeUrl), capability);

            FirefoxOptions firefoxOptions = new FirefoxOptions();
            
            _driver = new RemoteWebDriver(new Uri(nodeUrl), firefoxOptions);

            _driver.Manage().Window.Maximize();
            _objectContainer.RegisterInstanceAs(_driver);

            //在容器里生成了一个webdriver chrome 对象。对象
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario

            _driver.Close();
        }
    }
}
