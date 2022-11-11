using OpenQA.Selenium;

namespace evalbdd.ComponentHelper
{
	public class ButtonHelper
	{
		public static void ClickButton(By locator)
		{
			GenericHelper.GetElement(locator).Click();
		}
	}
}

