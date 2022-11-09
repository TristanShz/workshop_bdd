using snakegameworkshop.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;

namespace snakegameworkshop.Tests.TextBoxTests
{
	[TestClass]
	public class TextBoxTests
	{
		[TestMethod]
		public void TextBoxTest()
		{
			GenericHelper.GetElement(By.Id("p1")).SendKeys(ObjectRepository.Config.GetPlayerOne());
            GenericHelper.GetElement(By.Id("p2")).SendKeys(ObjectRepository.Config.GetPlayerTwo());
        }

		[TestMethod]
		public void TextBoxFromHelperTest()
		{
			TextBoxHelper.TypeInTextBox(By.Id("p1"), ObjectRepository.Config.GetPlayerOne());
            TextBoxHelper.TypeInTextBox(By.Id("p2"), ObjectRepository.Config.GetPlayerTwo());
        }

		[TestMethod]
		public void ClearTextBoxTest()
		{
			TextBoxHelper.ClearTextBox(By.Id("p1"));
            TextBoxHelper.ClearTextBox(By.Id("p2"));
        }
    }
}

