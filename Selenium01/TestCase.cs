using NUnit.Framework;
using selenium.csharp.framework;

namespace selenium.csharp.scripts
{
	public class TestCase : ScriptBase
	{
		[Test]
		public void ExecuteTest()
		{
			pageObject.SearchText("goku");
			pageObject.ClickSearchButton();
		}

	}


}
