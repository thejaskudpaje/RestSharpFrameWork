using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using V_Tiger_Nunit_FW.GenericUtility;
namespace V_Tiger_Nunit_FW.ObjectRepository
{
    public class HomePageMoreDropDown
    {

        [FindsBy(How = How.XPath, Using = "//img[@src='themes/softed/images/menuDnArrow.gif']")] private IWebElement moreDropDown { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@name='Campaigns']")] private IWebElement campaignLink { get; set; }

        public HomePageMoreDropDown(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void MoreDropDown()
        {
            WebDriverUtility webAction = new WebDriverUtility();
            // webAction.MouseHover(moreDropDown);
            moreDropDown.Click();

        }
        public void CampaignLink()
        {
            campaignLink.Click();
        }
    }
}
