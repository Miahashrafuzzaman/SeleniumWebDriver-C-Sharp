using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace selenium.csharp
{
	// Faced the issue to build the project once ... not sure how it was resolved... Need to investigate further...
	class MainClass
	{
		IWebDriver driver;
		SeleniumSetMethods set;
		public static void Main(string[] args)
		{

		}

		[SetUp]
		public void SetUp()
		{
			driver = new ChromeDriver(@"/Users/masihur/MyDevelopment/Selenium/C#/Selenium01/Selenium01/");
			set = new SeleniumSetMethods(driver);
			//driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
			driver.Navigate().GoToUrl("http:www.google.com");
		}
		[Test]
		public void ExecuteTest()
		{
			set.EnterText("Masihur", "q");
			set.ClickSeaarch("btnG");
		}
		[TearDown]
		public void TearDown()
		{
			//driver.Close();
		}

	}


	
}
