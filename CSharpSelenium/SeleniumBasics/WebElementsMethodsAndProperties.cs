using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.SeleniumBasics
{
    [TestClass]
    public class WebElementsMethodsAndProperties
    {
        IWebDriver driver;
        IWebElement element;
        [TestMethod]
        public  void MethodsAndPropertiesOfWebDriver()
        {
            bool Displayed=element.Displayed;
            bool enabled=element.Enabled;
            var size=element.Size;
            Point location=element.Location;
            string tagName=element.TagName;
            bool selected=element.Selected;
            string text=element.Text;
            var attribute= element.GetAttribute(driver.CurrentWindowHandle);
            element.GetCssValue(driver.CurrentWindowHandle);
            element.GetProperty(driver.CurrentWindowHandle);
            element.Clear();
            element.Click();
            element.Submit();
            element.SendKeys("");
            element.ToString();
           
        }
    }
}
