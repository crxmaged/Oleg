using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebTest
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver @driver = new ChromeDriver();
			//ChromeDriver chrome = new ChromeDriver();
			driver.Navigate().GoToUrl("http://www.google.com");
			driver.FindElement(By.Name("q")).SendKeys("Learn Automation");
			// driver.FindElement(By.Id("spch")).SendKeys(" ");
			// driver.
			// driver.Quit();
		}
	}
}
