using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace selenium.csharp.pageobject
{
	public class GooglePageObject
	{
		private UtilMethods set;

		public GooglePageObject(IWebDriver driver)
		{
			PageFactory.InitElements(driver, this);
			set = new UtilMethods(driver);
		}

		[FindsBy(How = How.Name, Using = "q")]
		private IWebElement TextBox { get; set; }

		[FindsBy(How = How.Name, Using = "btnG")]
		private IWebElement SearchButton{ get;set; }

		public void SearchText(string text)
		{
			set.EnterText(TextBox, text);
		}

		public void ClickSearchButton()
		{
			set.ClickElement(SearchButton);
		}
			
	}
}
