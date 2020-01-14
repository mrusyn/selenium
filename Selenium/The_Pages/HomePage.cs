using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pages.The_Pages
{
	public class HomePage : APage<HomePage_Selectors>
	{
		public HomePage(Pages d)
				: base(d, new HomePage_Selectors())
		{
		}

		public void Open(string url)
		{
			page.OpenURL(url);
		}

		/// <summary>
		/// Waits for Dialog to be visible
		/// </summary>
		public HomePage WaitForDialog()
		{
			page.WaitForPopup("User Information");
			return page.HomePage;
		}
	}

	public class HomePage_Selectors
	{
		public readonly By FullNameValue = By.XPath("//td[text()='Full Name:']/../td[2]");
		public readonly By Dialog = By.CssSelector("div.dlgTitle");
		public readonly By CloseButton = By.Name("close");
	}
}
