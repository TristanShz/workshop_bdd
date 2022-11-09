using System;
using OpenQA.Selenium;

namespace snakegameworkshop.ComponentHelper
{
	public class ButtonHelper
	{
		public static void ClickButton(By locator)
		{
			GenericHelper.GetElement(locator).Click();
		}
	}
}

