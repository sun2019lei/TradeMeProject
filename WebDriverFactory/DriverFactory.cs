using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace TradeMeGridAndUploadProject.WebDriverFactory
{
    public class WebDriverFactories
    {

        public IWebDriver Create(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return GetChromeDriver();
                /*   case BrowserType.Edge:
                       return GetEdge();*/
                default:
                    throw new ArgumentOutOfRangeException("No such browser exist");

            }

        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = GetAssemblyOutPutDirectory();
            var directoryWithChromeDriver = CreateFilePathForNetCoreApps(outPutDirectory);
            if (string.IsNullOrEmpty(outPutDirectory))
            {
                directoryWithChromeDriver = CreateFilePathForNetFrameWorkApps(outPutDirectory);
            }
            return new ChromeDriver(directoryWithChromeDriver);
        }


        private static string GetAssemblyOutPutDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        private static string CreateFilePathForNetFrameWorkApps(string outPutDirectory)
        {
            return Path.GetFullPath(Path.Combine(outPutDirectory ?? throw new InvalidOperationException(), @""));
        }
        private static string CreateFilePathForNetCoreApps(string outPutDirectory)
        {
            var resourceDirectory = "";
            if (outPutDirectory != null && outPutDirectory.Contains("netcoreapp"))
            {
                resourceDirectory = Path.Combine(outPutDirectory, @"");
            }

            return resourceDirectory;

        }
    }
}
