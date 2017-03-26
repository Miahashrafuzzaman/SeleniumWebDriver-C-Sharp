using System;
using OpenQA.Selenium;

namespace selenium.csharp
{
	public class UtilMethods
	{
		private IWebDriver driver;

		public UtilMethods(IWebDriver driver)
		{
			this.driver = driver;
		}

		// Enter Text in the desired element
		public void EnterText(IWebElement element, string value)
		{
			element.Clear();
			element.SendKeys(value);
		}
		 
		// Click the desired element.
		public void ClickElement(IWebElement element)
		{
			element.Click();
		}
			
	}
}
