using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTests
{
	[TestFixture]
	public class HomePageTest 
	{
		IWebDriver driver;

		[SetUp]
		public void Initialize()
		{
			driver = new ChromeDriver(@"C:\Users\MRusyn\Downloads\chromedriver_win32\chromedriver.exe");
			driver.Navigate().GoToUrl("http://www.google.com");
			Console.WriteLine("Opened URL");
		}

		[Test]
		public void TheUploadScriptTest()
		{
			IWebDriver dr = new ChromeDriver(@"C:\Users\MRusyn\Downloads\chromedriver_win32\chromedriver.exe");
			dr.Navigate().GoToUrl("https://testguild.com/selenium-webdriver-visual-studio/");	
		}
	}
}
