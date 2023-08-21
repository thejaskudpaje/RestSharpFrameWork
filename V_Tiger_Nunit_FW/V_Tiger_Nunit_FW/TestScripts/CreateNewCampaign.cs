using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V_Tiger_Nunit_FW.GenericUtility;
using V_Tiger_Nunit_FW.ObjectRepository;

namespace V_Tiger_Nunit_FW.TestScripts
{
    [TestFixture]
    public class CreateNewCampaign : BaseClass
    {
        [Test]
        [Author("Thejas")]
        public void Create_New_campaign()
        {
   
            CampaignsHomePage campaignHome = new CampaignsHomePage(driver);
            CreatingNewCampaignPage createCampaign = new CreatingNewCampaignPage(driver);
            WebDriverUtility webaction = new WebDriverUtility();
            HomePage home = new HomePage(driver);
            HomePageMoreDropDown moreDD = new HomePageMoreDropDown(driver);
          
             home.getMore();
           
            moreDD.CampaignLink();
          
            campaignHome.click_on_add();

          
            string campaignName = "Mi Mobiles";
            string campaignType = "Advertisement";
            string campaignStatus = "Planning";
            string revenue = "2000000";
            string closeDate = "10/20/2023";
            createCampaign.CreateNewCampaign_Test(campaignName, campaignType, campaignStatus, revenue, closeDate);
            string campaignNo = driver.FindElement(By.XPath("//td[text()='Campaign No']/following-sibling::td[@class='dvtCellInfo']")).Text;

            campaignHome.campaign_Link.Click();
            campaignNo = campaignNo.Trim();
            Console.WriteLine(campaignNo);


            string act_campaignName = driver.FindElement(By.XPath("//td[contains(text(),'" + campaignNo + "')]/following-sibling::td/a[@title='Campaigns']")).Text;
            act_campaignName = act_campaignName.Trim();
            CreateNewCampaign createcampaign = new CreateNewCampaign();
            createcampaign.Validation_Test("Campaign Name", campaignName, act_campaignName);


        }
        public void Validation_Test(string validatationName, string expected, string actual)
        {
        
             test = extent_Reports.CreateTest(TestContext.CurrentContext.Test.Name);
            try
            {
                Assert.AreEqual(expected, actual);

                test.Pass(validatationName + " ValidationPass");
                ScreenShotClass ss = new ScreenShotClass();
                string screenshot=ss.Save_ScreenShot();
                Console.WriteLine("hellooo");
                //string Screenhot_path = "G:\\TYSS\\C#\\projects\\V_Tiger_Nunit_FW\\V_Tiger_Nunit_FW\\ScreenshotsFolder\\";
             //   string Screenhot_path = $"G:\\TYSS\\C#\\projects\\V_Tiger_Nunit_FW\\V_Tiger_Nunit_FW\\ScreenshotsFolder\\{TestContext.CurrentContext.Test.Name}.png";
                test.AddScreenCaptureFromPath(screenshot);

            }
            catch (Exception ex)
            {
                test.Fail(validatationName + " Validation fail");
            }
          
        }
    }
}
