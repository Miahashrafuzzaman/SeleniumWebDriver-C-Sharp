using System;
using OpenQA.Selenium;

namespace selenium.csharp
{
	public class SeleniumSetMethods
	{
		private IWebDriver driver;
		public SeleniumSetMethods(IWebDriver driver)
		{
			this.driver = driver;
		}

		public void EnterText(string value, string elementType)
		{
			IWebElement element = driver.FindElement(By.Name(elementType));
			element.Clear();
			element.SendKeys(value);
		}
		 
		public void ClickSeaarch(string elementType)
		{
			IWebElement element = driver.FindElement(By.Name(elementType));
			element.Click();
		}
			
	}
}
