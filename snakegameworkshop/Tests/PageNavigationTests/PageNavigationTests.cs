using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace snakegameworkshop.Tests.PageNavigationTests
{
	[TestClass]
	public class PageNavigationTests
	{
		[TestMethod]
		public void OpenUrlFromDriver()
		{
			IWebDriver driver = new ChromeDriver();
			driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
			driver.Close();
			driver.Quit();
		}

		[TestMethod]
		public void OpenUrlFromObjectRepository()
		{
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }

		[TestMethod]
		public void OpenUrlFromObjectRepositoryAndGetTitle()
		{
            NavigationHelper.NavigateToHomePage();
            Console.WriteLine(ObjectRepository.Driver.Title);
		}

		[TestMethod]
		public void OpenUrlFromObjectRepositoryAndGetTitleFromPageHelper()
		{
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine(PageHelper.GetPageTitle());
        }
	}
}

