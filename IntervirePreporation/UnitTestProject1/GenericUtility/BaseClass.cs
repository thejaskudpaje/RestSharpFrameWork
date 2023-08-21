using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UnitTestProject1.GenericUtility
{
    [TestClass]
    public class BaseClass
    {
        public static TestContext text_context;
        public static IWebDriver driver = new ChromeDriver();

        [AssemblyInitialize]
        public static void Init_Method(TestContext tc)
        {
            text_context = tc;
          //  MessageBox.Show("Assembly initializing");
        }

        [AssemblyCleanup]
        public static void Cleanup_Method() {

        }

    }
}
