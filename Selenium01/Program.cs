using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Selenium01
{
	// Faced the issue to build the project once ... not sure how it was resolved... Need to investigate further...
	class MainClass
	{
		IWebDriver driver = new ChromeDriver(@"/Users/masihur/MyDevelopment/Selenium/C#/Selenium01/Selenium01/");

		public static void Main(string[] args)
		{

		}

		[SetUp]
		public void SetUp()
		{
			driver.Navigate().GoToUrl("http://www.google.com");
		}
		[Test]
		public void ExecuteTest()
		{
			IWebElement element = driver.FindElement(By.Name("q"));
			element.SendKeys("Masihur's Blog \n");
		}
		[TearDown]
		public void TearDown()
		{
			driver.Close();
		}

	}


	
}
