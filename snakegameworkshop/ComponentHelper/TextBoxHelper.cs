using System;
using OpenQA.Selenium;

namespace snakegameworkshop.ComponentHelper
{
	public class TextBoxHelper
	{
		public static void TypeInTextBox(By locator, string text)
		{
			GenericHelper.GetElement(locator).SendKeys(text);
		}

		public static void ClearTextBox(By locator)
		{
			GenericHelper.GetElement(locator).Clear();
		}
	}
}

