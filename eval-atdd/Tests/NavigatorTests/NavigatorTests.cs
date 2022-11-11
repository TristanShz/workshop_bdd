using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace evalbdd
{
	[TestClass]
	public class NavigatorTests
	{

        [TestMethod]
        public void OpenConfigBrowserWithBaseClass()
        {
            Console.WriteLine(ObjectRepository.Config.GetWebsite());
        }

        [TestMethod]
        [Ignore]
        public void OpenChromeAndGoToHomePage()
        {
            IWebDriver driver = new ChromeDriver();
            IConfig config = new ConfigReader();
            driver.Navigate().GoToUrl(config.GetWebsite());
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void OpenFirefoxAndGoToHomePage()
        {
            IWebDriver driver = new FirefoxDriver();
            IConfig config = new ConfigReader();
            driver.Navigate().GoToUrl(config.GetWebsite());
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        [Ignore]
        public void OpenInternetExplorerAndGoToHomePage()
        {
            IWebDriver driver = new InternetExplorerDriver();
            IConfig config = new ConfigReader();
            driver.Navigate().GoToUrl(config.GetWebsite());
            driver.Close();
            driver.Quit();
        }
    }
}

