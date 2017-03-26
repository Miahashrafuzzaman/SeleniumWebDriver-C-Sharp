using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium01
{
	// Need System.core package to be adde tin the reference to work... Don't know the reason
	class MainClass
	{
		public static void Main(string[] args)
		{
			/// Need the chromedriver in the path secified with latest version of mac.
			IWebDriver driver = new ChromeDriver(@"/Users/masihur/MyDevelopment/Selenium/C#/Selenium01/Selenium01/");
			driver.Navigate().GoToUrl("http://www.google.com");

			IWebElement element = driver.FindElement(By.Name("q"));
			element.SendKeys("Masihur's Blog \n");
			//element.SendKeys(Keys.Enter);
			driver.Close();
		}
	}
	
}
