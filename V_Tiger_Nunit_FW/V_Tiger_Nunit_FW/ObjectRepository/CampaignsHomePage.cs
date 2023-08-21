using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
namespace V_Tiger_Nunit_FW.ObjectRepository
{

    public class CampaignsHomePage
    {

      [FindsBy(How = How.XPath, Using = "//img[@alt='Create Campaign...']")] private IWebElement add_symbol { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='hdrLink']")] private IWebElement campaignLink;//{ get; set; }
      
         public IWebElement campaign_Link
        {
            get { return campaignLink; }
              set { campaignLink = value; }

        }
        public CampaignsHomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void click_on_add()
        {
             add_symbol.Click();
        }


    }
}
