using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Configuration;
using System;
using evalbdd;

namespace evalbdd
{
    
    [TestClass]
    public class SettingTests
    {
        private CreditCardSettings settings;

        [TestInitialize]
        public void init()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables().Build();

            settings = config.GetRequiredSection(nameof(CreditCardSettings)).Get<CreditCardSettings>();
        }

        [TestMethod] public void GetBrowserFromConfig()
        {
            Console.WriteLine($"Browser = {settings.Browser}");
        }

        [TestMethod]
        public void GetValidCardNumberFromConfig()
        {
            Console.WriteLine($"CardNumber = {settings.ValidCardNumber}");
        }

        [TestMethod]
        public void GetValidExpirationDateFromConfig()
        {
            Console.WriteLine($"ExpirationDate = {settings.ValidExpirationDate}");
        }

        [TestMethod]
        public void GetValidCvcFromConfig()
        {
            Console.WriteLine($"Cvc = {settings.ValidCvc}");   
        }
        
        public void GetInvalidCardNumberFromConfig()
        {
            Console.WriteLine($"CardNumber = {settings.InvalidCardNumber}");
        }

        [TestMethod]
        public void GetInvalidExpirationDateFromConfig()
        {
            Console.WriteLine($"ExpirationDate = {settings.InvalidExpirationDate}");
        }

        [TestMethod]
        public void GetInvalidCvcFromConfig()
        {
            Console.WriteLine($"Cvc = {settings.InvalidCvc}");   
        }
        
        [TestMethod]
        public void GetWebsiteFromConfig()
        {
            Console.WriteLine($"Website = {settings.Website}");
        }

    }
}

