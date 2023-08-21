using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Tiger_Nunit_FW.GenericUtility
{
    /// <summary>
    /// This class is going to provide the Webdriver methods to the particular scripts.
    /// </summary>

    public class WebDriverUtility : BaseClass
    {
        /// <summary>
        /// This method is going to provide the implicit wait.
        /// </summary>
        /// <param name="driver"></param>
        [Author("Datta")]
        public void WaitImplicitly(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        /// <summary>
        /// This method is going to perfom the maximise of the browser window
        /// </summary>
        /// <param name="driver"></param>
        [Author("Datta")]
        public void MaximiseWindow(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }
        /// <summary>
        /// This method is used to select the element present in the list box
        /// </summary>
        [Author("Thejas")]
        public void ListBox_SelectByValue(IWebElement element, string value)
        {
          //  SelectElement select = new SelectElement(element);
         //   select.SelectByValue(value);

        }
        [Author("Thejas")]
        /// <summary>
        /// use of this method to select the element inside the list box by providing the list box  value
        /// </summary>
        public void Select_List( string inputValue, IList<IWebElement> listOfElements)
        {
         
            foreach (IWebElement i in listOfElements)
            {
                string val = i.GetAttribute("value");
                if (inputValue.Equals(val))
                {
                    i.Click();
                }
            }

        }

        [Author("Thejas")]
        public void Mouse_Hover(IWebElement element)
        {
            Actions actions=new Actions(driver);
            actions.MoveToElement(element).Perform();
        }

    }
}
