using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pages;

namespace Tests
{
	[TestClass]
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
					driver = new ChromeDriver(Environment.CurrentDirectory);
					driver.Manage().Window.Maximize();
				}
				return driver;
			}
		}

		protected Pages.Pages Page => _page ?? (_page = new Pages.Pages(
			driver: Driver));


		/// <summary>
		/// Default clean up method that is executed after all tests in class were finished.
		/// Quits driver and asserts verification errors for emptiness.
		/// </summary>
		[ClassCleanup]
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

		[ClassInitialize]
		public void FixtureSetUpTest()
		{

		}
	}
}
