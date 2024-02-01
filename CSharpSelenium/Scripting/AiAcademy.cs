using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CSharpSelenium.Scripting
{
    [TestClass]
    public class AiAcademy
    {
        string url = "https://nxtgenaiacademy.com/alertandpopup/";

        [TestMethod,TestCategory("AiAcademy")]
        public void AiAcademyTest1()
        {
            
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[.='Prompt Alert Box']")).Click();
            driver.SwitchTo().Alert().SendKeys("no");
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
        }
    }
}
