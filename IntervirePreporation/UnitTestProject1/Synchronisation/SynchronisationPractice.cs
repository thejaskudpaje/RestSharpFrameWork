using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Synchronisation
{
    [TestClass]
    [TestCategory("Synchronization")]
    public class SynchronisationPractice
    {
        [TestMethod]
        public void Synch_Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://google.com");
            driver.FindElement(By.ClassName("google"));
         //   driver.FindElements(By.ClassName("google"));
        }
    }
}
