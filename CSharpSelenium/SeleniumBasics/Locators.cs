using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpSelenium.SeleniumBasics
{
    [TestClass]
    public class Locators
    {
        IWebDriver driver;
        [TestMethod]
        [TestCategory("ByLocators")]
        public void LocatorsFromByClass()
        {
            try
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://demo.actitime.com/");
                driver.FindElement(By.Id("username")).SendKeys("admin");
                Thread.Sleep(1000);
                driver.FindElement(By.Name("username")).SendKeys("adusernamemin");
                Thread.Sleep(1000);
                driver.FindElement(By.ClassName("textField")).SendKeys("aein");
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//input[@name='username']")).SendKeys("ada123154min");
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector("input[name='username']")).SendKeys("789456231");
                string t0 = driver.FindElement(By.PartialLinkText("Login")).Text;

                string t1 = driver.FindElement(By.LinkText("actiTIME Inc.")).Text;
                Thread.Sleep(1000);

                string title = driver.FindElement(By.TagName("div")).Text;
                Console.WriteLine(t0);
                Console.WriteLine(t1);
                Console.WriteLine(title);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally{
            driver.Close();
            driver.Quit();
            driver.Dispose(); }
        }

        [TestMethod]
        [TestCategory("TestingLinkText")]
        public void TestingLinkText()
        {
            driver=new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            string text = driver.FindElement(By.PartialLinkText("Log i")).Text;
            driver.FindElement(By.LinkText("Log in")).Click();
            Console.WriteLine(text);
        }

        
        public static void Main()
        {
           
        }
    }
}
