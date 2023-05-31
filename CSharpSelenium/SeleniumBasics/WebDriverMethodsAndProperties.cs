using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.SeleniumBasics
{
    [TestClass]
    public class WebDriverMethodsAndProperties
    {
        IWebDriver driver;
        [TestInitialize]
        public void TestIni()
        {
            driver = new ChromeDriver();
        }
        [TestMethod]
        [TestCategory("Regression"),TestCategory("WebdriverMethods")]
        public void WebDriverMethods()
        {
            
            driver.Navigate().GoToUrl("https://www.google.com/");
            string url=driver.Url;
            string title = driver.Title;
            string PageSource=driver.PageSource;
            string CurrentWindowHandle=driver.CurrentWindowHandle;
            IReadOnlyCollection<string> WindowHandles = driver.WindowHandles;
;       }

        [TestMethod]
        [TestCategory("WebDriverProperties"), TestCategory("Smoke")]
        public void WebDriverProperties()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Timeouts().PageLoad=TimeSpan.FromSeconds(10);
            driver.SwitchTo().Window("");
            driver.FindElement(By.XPath(""));
            driver.FindElements(By.XPath(""));
        }

        [TestCleanup]
        public void TestCup()
        {
            driver.Close();
            driver.Dispose();
        }

    }
}
