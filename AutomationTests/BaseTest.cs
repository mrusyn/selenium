using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pages;
using System;


namespace AutomationTests
{
	/// <summary>
	/// Base class that contains common objects/elements/cleanup used in UI and API tests.
	/// </summary>
	public abstract class BaseTest
	{

		private IWebDriver driver;
		private Pages.Pages _page;

		/// <summary>
		/// WebDriver to be used in tests and page objects. Defaults to ChromeDriver if not overwritten in tests.
		/// </summary>
		protected IWebDriver Driver
		{
			get
			{
				if (driver == null)
				{
					driver = new ChromeDriver(@"C:\Users\MRusyn\Downloads\selenium-dotnet-3.14.0\dist");
					driver.Manage().Window.Maximize();
				}
				return driver;
			}
		}

		/// <summary>
		/// Clears the current page so a new page is object is created with the next page use.
		/// </summary>
		protected void ResetPage()
		{
			driver = null;
			_page = null;
		}

		protected Pages.Pages Page => _page ?? (_page = new Pages.Pages(
			driver: Driver));



		/// <summary>
		/// Default clean up method that is executed after all tests in class were finished.
		/// Quits driver and asserts verification errors for emptiness.
		/// </summary>
		[OneTimeTearDown]
		public void FixtureTeardownTest()
		{
			
			try
			{
				if (driver != null)
					driver.Quit();
			}
			catch (Exception e)
			{			
				Console.WriteLine($"Error cleaning up webdriver: {e.ToString()}");
			}
			
		}

		[OneTimeSetUp]
		public void FixtureSetUpTest()
		{

		}
	}
}
