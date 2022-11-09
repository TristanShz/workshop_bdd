using System;
using Microsoft.Extensions.Configuration;

namespace snakegameworkshop
{
	public class ConfigReader: IConfig
	{
        private GameSettings settings;

        public ConfigReader()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(GameSettings)).Get<GameSettings>();
        }

        public BrowserType GetBrowser()
        {
            string browser = settings.Browser;

            try
            {
                return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
            }
            catch (ArgumentException)
            {
                throw new NoSuitableDriverFound("Aucun driver n'a été trouvé  : " + settings.Browser);
            }
        }

        public string GetPlayerOne()
        {
            return settings.PlayerOne;
        }

        public string GetPlayerTwo()
        {
            return settings.PlayerTwo;
        }

        public string GetWebsite()
        {
            return settings.Website;
        }
    }
}

