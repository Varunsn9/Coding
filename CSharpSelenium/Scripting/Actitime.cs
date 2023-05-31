using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpSelenium.Scripting
{
    [TestClass]
    public class Actitime
    {
        IWebDriver driver;
        [TestMethod]
        [TestCategory("ScrollDown")]
        public void ScrollTesting()
        {
            driver=new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demo.actitime.com");
            driver.FindElement(By.Id("username")).SendKeys("admin");
            driver.FindElement(By.Name("pwd")).SendKeys("manager");
            driver.FindElement(By.XPath("//div[.='Login ']")).Click();
            driver.FindElement(By.XPath("//a[.='View Time-Track']")).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 1800)");
            var element = "//a[.='Enter Time-Track']";
            //driver.Navigate().Refresh();
            Thread.Sleep(2000);
            var ele=driver.FindElement(By.XPath(element));
            int a=ele.Location.X;
            int b=ele.Location.Y;
            
            
            js.ExecuteScript($"window.scrollTo({a},{b})");
        }

        [TestMethod]
        [TestCategory("IWebElement")]
        public void TestingIWebElement()
        {

            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demo.actitime.com");
            driver.FindElement(By.Id("username")).SendKeys("admin");
            driver.FindElement(By.Name("pwd")).SendKeys("manager");
            driver.FindElement(By.XPath("//div[.='Login ']")).Click();
            IWebElement element= driver.FindElement(By.XPath("//a[.='View Time-Track']"));
            
            string getCSSValue= element.GetCssValue("background-color");
            //pass the Css type it returns the value
            Console.WriteLine(getCSSValue);

            string getProperty=element.GetProperty("hideFocus");
            Console.WriteLine(getProperty);
            //pass the JavaScript of the element it returns the value

            string attribute=element.GetAttribute("class");
            Console.WriteLine(attribute);

            

        }
    }
}
