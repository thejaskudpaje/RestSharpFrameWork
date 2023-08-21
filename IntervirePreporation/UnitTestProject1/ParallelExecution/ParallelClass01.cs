using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.GenericUtility;


[assembly: Parallelize(Workers = 3, Scope = ExecutionScope.ClassLevel)]
namespace UnitTestProject1.ParallelExecution
{
    [TestClass]
    [TestCategory("ParallelExecution")]
    public class ParallelClass01 : BaseClass
    {
    
        [TestMethod]
        public void Test01()
        {
          
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
        }

        [TestMethod]
        public void Test02()
        {
            
            driver.Navigate().GoToUrl("https://www.amazon.in/");
        }
    }
}
