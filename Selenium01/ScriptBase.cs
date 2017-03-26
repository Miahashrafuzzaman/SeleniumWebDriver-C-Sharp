using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium.csharp.pageobject;

namespace selenium.csharp.framework
{
	public class ScriptBase
	{
		protected IWebDriver driver;

		protected GooglePageObject pageObject;

		[SetUp]
		public void SetUp()
		{
			driver = new ChromeDriver(@"/Users/masihur/MyDevelopment/Selenium/C#/Selenium01/Selenium01/");
			pageObject = new GooglePageObject(driver);
			driver.Navigate().GoToUrl("http:www.google.com");
		}

		[TearDown]
		public void TearDown()
		{
			driver.Close();
		}
	}
}
