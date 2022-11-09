using System;
using OpenQA.Selenium;

namespace snakegameworkshop
{
	public class ObjectRepository
	{
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}

