using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Configuration;
using System;

namespace snakegameworkshop
{
    
    [TestClass]
    public class SettingTests
    {
        private GameSettings settings;

        [TestInitialize]
        public void init()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables().Build();

            settings = config.GetRequiredSection(nameof(GameSettings)).Get<GameSettings>();
        }

        [TestMethod] public void GetBrowserFromConfig()
        {
            Console.WriteLine($"Browser = {settings.Browser}");
        }

        [TestMethod]
        public void GetPlayerOneFromConfig()
        {
            Console.WriteLine($"PlayerOne = {settings.PlayerOne}");
        }

        [TestMethod]
        public void GetPlayerTwoFromConfig()
        {
            Console.WriteLine($"PlayerTwo = {settings.PlayerTwo}");
        }

        [TestMethod]
        public void GetWebsiteFromConfig()
        {
            Console.WriteLine($"Website = {settings.Website}");
        }

    }
}

