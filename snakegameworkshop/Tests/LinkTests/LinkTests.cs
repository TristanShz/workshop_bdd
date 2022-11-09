using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using snakegameworkshop.ComponentHelper;

namespace snakegameworkshop.Tests.LinkTests
{

	[TestClass]
	public class LinkTests
	{
        [TestInitialize]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
        }

        [TestMethod]
		public void ClickLinkTest()
		{
			GenericHelper.GetElement(By.LinkText("Contact")).Click();
        }

		[TestMethod]
		public void ClickLinkFromHelperTest()
		{
			LinkHelper.ClickLink(By.LinkText("Contact"));
        }
	}
}

