using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.GenericUtility
{
    [TestClass]
    [TestCategory("WebActionUtility")]
    public class WebActionUtility
    {
        IWebDriver driver;
        [TestMethod]
        public void Explicit_Wait_Test()
        {
            driver=new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://www.amazon.in/");
             wait.Until(ExpectedConditions.ElementExists(By.Id("glow-ingress-line1"))).Click ();
        }
    }
}
