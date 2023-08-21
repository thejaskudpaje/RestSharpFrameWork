using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.GenericUtility;

namespace UnitTestProject1.ParallelExecution
{
    [TestClass]
    [TestCategory("ParallelExecution")]
    public  class ParallelClass02 : BaseClass
    {
        //public static IWebDriver driver = new ChromeDriver();
        [TestMethod]
        public void Test03()
        {
            driver.Navigate().GoToUrl("http://javapoint.com/");
        }

        [TestMethod]
        public void Test04()
        {
            driver.Navigate().GoToUrl("https://www.w3schools.com/");
        }
    }
}
