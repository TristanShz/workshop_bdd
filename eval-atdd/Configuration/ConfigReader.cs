using System;
using evalbdd.Settings;
using Microsoft.Extensions.Configuration;

namespace evalbdd
{
	public class ConfigReader: IConfig
	{
        private CreditCardSettings settings;

        public ConfigReader()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(CreditCardSettings)).Get<CreditCardSettings>();
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
        
        public string GetValidCardNumber()
        {
            return settings.ValidCardNumber;
        }

        public string GetValidExpirationDate()
        {
            return settings.ValidExpirationDate;
        }

        public string GetValidCvc()
        {
            return settings.ValidCvc;
        }
        
        public string GetInvalidCardNumber()
        {
            return settings.InvalidCardNumber;
        }

        public string GetInvalidExpirationDate()
        {
            return settings.InvalidExpirationDate;
        }

        public string GetInvalidCvc()
        {
            return settings.InvalidCvc;
        }
        public string GetWebsite()
        {
            return settings.Website;
        }
    }
}

