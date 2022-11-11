using System;
using OpenQA.Selenium;

namespace evalbdd
{
	public class ObjectRepository
	{
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}

