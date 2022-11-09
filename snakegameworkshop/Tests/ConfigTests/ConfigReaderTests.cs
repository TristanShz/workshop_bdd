using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace snakegameworkshop
{
	[TestClass]
	public class ConfigReaderTests
	{
        [TestMethod]
        public void GetSettingsKeysFromConfigReader()
        {
            Console.WriteLine("Browser : " + ObjectRepository.Config.GetBrowser());
            Console.WriteLine("Player Two : " + ObjectRepository.Config.GetPlayerOne());
            Console.WriteLine("Player One : " + ObjectRepository.Config.GetPlayerTwo());
            Console.WriteLine("Website : " + ObjectRepository.Config.GetWebsite());
        }
    }
}

