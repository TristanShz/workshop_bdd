using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using snakegameworkshop.ComponentHelper;

namespace snakegameworkshop.Tests.ButtonTests
{
	[TestClass]
	public class ButtonTests
	{
        [TestInitialize]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
        }

        [TestMethod]
		public void ClickOnButtonTest()
		{
			TextBoxHelper.TypeInTextBox(By.Id("p1"), ObjectRepository.Config.GetPlayerOne());
            TextBoxHelper.TypeInTextBox(By.Id("p2"), ObjectRepository.Config.GetPlayerTwo());
			GenericHelper.GetElement(By.Id("submitPlayers")).Click();
        }

		[TestMethod]
		public void ClickOnButtonFromHelperTest()
		{
			ButtonHelper.ClickButton(By.Id("submitPlayers"));
		}
	}
}

