using System;
using evalbdd.Settings;

namespace evalbdd
{
	public interface IConfig
	{
		public BrowserType GetBrowser();
		public string GetValidCardNumber();
		public string GetValidExpirationDate();
		public string GetValidCvc();
		public string GetInvalidCardNumber();
		public string GetInvalidExpirationDate();
		public string GetInvalidCvc();
		public string GetWebsite();
	}
}

