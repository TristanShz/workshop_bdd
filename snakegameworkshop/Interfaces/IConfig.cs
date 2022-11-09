using System;
namespace snakegameworkshop
{
	public interface IConfig
	{
		public BrowserType GetBrowser();
		public string GetPlayerOne();
		public string GetPlayerTwo();
		public string GetWebsite();
	}
}

