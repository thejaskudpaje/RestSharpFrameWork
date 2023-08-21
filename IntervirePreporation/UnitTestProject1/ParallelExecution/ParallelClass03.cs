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
    public class ParallelClass03 : BaseClass
    {
  
        [TestMethod]
        public void Test05()
        {
            driver.Navigate().GoToUrl("https://github.com/");
        }

        [TestMethod]
        public void Test06()
        {
            driver.Navigate().GoToUrl("https://www.nuget.org/");
        }
    }
}
