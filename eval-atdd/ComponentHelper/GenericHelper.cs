using System;
using OpenQA.Selenium;

namespace evalbdd.ComponentHelper
{
    public class GenericHelper
    {
        public static bool IsElementPresentOnce(By locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(locator).Count == 1;
            }
            catch (Exception) { return false; }
        }
   
        public static bool IsElementPresentAtLeastOnce(By locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(locator).Count > 1;
            }
            catch (Exception) { return false; }
        }

        public static IWebElement GetElement(By locator)
        {
            if (IsElementPresentOnce(locator))
                return ObjectRepository.Driver.FindElement(locator);
            else
                throw new NoSuchElementException("Element not found" + locator.ToString());
        }
    }
}
