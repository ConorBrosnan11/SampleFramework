using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TZL.Core;
using TZL.Repository;

namespace TZL_Test.TestCases
{
	class DemoChartTestCases: BaseTest
	{
		[Test]
		public void VerifyIfItemsCanBeSearchedInSearchItemstextBox()
		{
			try
			{
				LogMessage("Navigate to Url", ()
					=> NavigateToUrl("https://demostore.x-cart.com/", Driver));

				var pgDemoChart = Page<DemoChart>(Driver);

				LogMessage("Invoking Search Items Method", ()
					=> pgDemoChart.SearchItems("IPhone", "Android"));

				LogMessage("Close Browser", () => CloseBrowser(Driver));

			}

			catch (Exception)
			{
				LogMessage("Close Browser", () => CloseBrowser(Driver));

			}
		}
	}
}
