using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace evalbdd
{
	[TestClass]
	public class ConfigReaderTests
	{
        [TestMethod]
        public void GetSettingsKeysFromConfigReader()
        {
            Console.WriteLine("Browser : " + ObjectRepository.Config.GetBrowser());
            Console.WriteLine("Valid Card Number : " + ObjectRepository.Config.GetValidCardNumber());
            Console.WriteLine("Valid Expiration Date : " + ObjectRepository.Config.GetValidExpirationDate());
            Console.WriteLine("Valid Cvc : " + ObjectRepository.Config.GetValidCvc());
            Console.WriteLine("Invalid Card Number : " + ObjectRepository.Config.GetInvalidCardNumber());
            Console.WriteLine("Invalid Expiration Date : " + ObjectRepository.Config.GetInvalidExpirationDate());
            Console.WriteLine("Invalid Cvc : " + ObjectRepository.Config.GetInvalidCvc());
            Console.WriteLine("Website : " + ObjectRepository.Config.GetWebsite());
        }
    }
}

