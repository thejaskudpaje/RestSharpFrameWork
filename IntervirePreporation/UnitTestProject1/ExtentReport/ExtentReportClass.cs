using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.ExtentReport
{
    [TestClass]
    [TestCategory("Extent Report")]
    public class ExtentReportClass
    {
        [TestMethod]
        public void Test_01()
        {
            ExtentReports extentReports = new ExtentReports();  
        }
    }
}
