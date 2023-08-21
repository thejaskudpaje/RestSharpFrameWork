using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V_Tiger_Nunit_FW.ObjectRepository;

namespace V_Tiger_Nunit_FW.GenericUtility
{
    public class BaseClass
    {
        public string Screenhot_path;
        public ExtentTest test;
        public static IWebDriver driver;
        public  static string path = "G:\\TYSS\\C#\\projects\\V_Tiger_Nunit_FW\\V_Tiger_Nunit_FW\\Reports\\";
        public static ExtentReports extent_Reports;
        public static ExtentHtmlReporter htmlReport;
        //public static string Screenhot_path = "G:\\TYSS\\C#\\projects\\V_Tiger_Nunit_FW\\V_Tiger_Nunit_FW\\ScreenshotsFolder\\" + ".png";


        [OneTimeSetUp ]
        public void One_Time_Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:8888/");
            extent_Reports = new ExtentReports();
            htmlReport = new ExtentHtmlReporter(path);
            extent_Reports.AttachReporter(htmlReport);
           
        }
        [OneTimeTearDown]
        public void One_Time_Tear()
        {
         extent_Reports.Flush();
           htmlReport.Stop();
            driver.Quit();
        }

        [SetUp]
        public void Login() {
            driver.FindElement(By.Name("user_name")).SendKeys("admin");
            driver.FindElement(By.Name("user_password")).SendKeys("password");
            driver.FindElement(By.Id("submitButton")).Click();
            
        }
        [TearDown]
        public void Logout() {
            HomePage hp = new HomePage(driver);
            hp.signOut();
        }

       
    }
}
