using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1.Synchronisation
{
    [TestClass]
    [TestCategory("Synchronization")]
    public class ExplicitWaitClass
    {
        IWebDriver driver = new ChromeDriver();
      
        [TestMethod]
        public void ExplicitWait_Test01()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            wait.Until(ExpectedConditions.ElementExists(By.Id("glow-ingress-line1"))).Click();
        }

        [TestMethod]
        public void ExplicitWait_Test02()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("glow-ingress-line"))).Click();
        }

        [TestMethod]
        public void ExplicitWait_Test03()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://www.aon.in");
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            wait.Until(ExpectedConditions.TitleContains("Amazon"));
            Console.WriteLine(driver.Title);
        }

    }
}
