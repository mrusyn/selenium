using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Net;
using Pages.The_Pages;

namespace Pages
{
	/// <summary>
	/// Pages class
	/// </summary>
	public class Pages
	{
		/// <summary>
		/// Driver
		/// </summary>
		public IWebDriver Driver;

		/// <summary>
		/// The time to wait before timing out.
		/// </summary>
		public WebDriverWait Wait;

		internal void WaitForPopup(string v)
		{
			throw new NotImplementedException();
		}


		private HomePage _homePage;

		/// <summary>
		/// HomePage
		/// </summary>
		public HomePage HomePage => _homePage ?? (_homePage = new HomePage(this));


		/// <summary>
		/// Initializer
		/// </summary>
		/// <param name="driver">Driver</param>		
		/// pages will append encoutered errors to it </param>
		/// <param name="baseURL">The base url to use in applicable funcitons</param>
		public Pages(IWebDriver driver)
		{
			Driver = driver;
		}

		public void OpenURL(string url)
		{
			Driver.Navigate().GoToUrl(url);

		}
	}
}
