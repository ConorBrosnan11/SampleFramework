using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TZL.Core;

namespace TZL.Repository
{
	public class DemoChart : BasePage
	{
		readonly IWebDriver _driver = null;

		#region Constructor

		public DemoChart(IWebDriver driver)
		{
			_driver = driver;
		}

		#endregion

		#region Object Repository

		private IWebElement SearchTestItems => _driver.css("input[placeholder='Search items...']");


		private IList<IWebElement> HotDealsLink => _driver.Allcss(".primary_title");

		private IWebElement Sale => _driver.LinkText("Sale");

		private IWebElement Iphone => _driver.LinkText("Search powered by CloudSearch");

		private IWebElement Android => _driver.LinkText("Search powered by CloudSearch");

		#endregion

		#region TestCase Methods

		public void SearchItems(string value1, string value2)
		{
			LogMessage("Entering a value into Search Items Test Box", ()
				 => Input(SearchTestItems, value1));

			LogMessage("Validating if iphones are Visible", ()
				 => AssertIsTrue(Iphone.Displayed));

			LogMessage("Entering a value into Search Items Text Box", ()
				 => ClearAndInput(SearchTestItems, value2));

			LogMessage("Validating if Android are Visible", ()
				 => AssertIsTrue(Iphone.Displayed));
		}


		public void HotDeals()
		{
			LogMessage("Mouse Hover On Hot Deals Text", ()
				=> MouseHover(HotDealsLink[1], _driver));

			LogMessage("Click On Sale Text", () => Click(Sale));
		}

			#endregion
	}
}
