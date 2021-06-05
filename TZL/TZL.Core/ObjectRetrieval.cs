using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZL.Core
{
	public static class ObjectRetrieval
	{
		public static IWebElement GetElement(this IWebDriver driver, By by, int waitTime = 10)
		{
			var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
			return wait.Until(ExpectedConditions.ElementExists(by));
		}

		public static IList<IWebElement> GetElements(this IWebDriver driver, By by, int waitTime = 10)
		{
			var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
			return wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
		}

		public static IList<IWebElement> Allcss(this IWebDriver driver, string cssSelector)
		{
			return driver.GetElements(By.CssSelector(cssSelector));
		}


		public static IWebElement css(this IWebDriver driver, string text)
		{
			return driver.GetElement(By.CssSelector(text));
		}


		public static IWebElement LinkText(this IWebDriver driver, string text)
		{
			return driver.GetElement(By.LinkText(text));
		}


	}
}
