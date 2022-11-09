using System;
using OpenQA.Selenium;

namespace snakegameworkshop.ComponentHelper
{
	public class LinkHelper
	{
        public static void ClickLink(By locator)
        {
            GenericHelper.GetElement(locator).Click();
        }

    }
}

