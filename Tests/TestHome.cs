using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
	[TestClass]
	public class TestHome : BaseTest
	{		
		[TestMethod]
		public void TestMethod1()
		{
			Page.HomePage.Open("https://www.pinterest.com/");
		}
	}
}
