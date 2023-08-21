using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Tiger_Nunit_FW.GenericUtility
{/// <summary>
/// use of this class to select the element inside the list box by providing the list box element and value
/// </summary>
    public class ListBox : BaseClass
    {
        public void Select_List(IWebElement element, string inputValue)
        {
            IList<IWebElement> listOfElements = driver.FindElements(By.XPath("//select[@name='campaigntype']/option"));
            foreach(IWebElement i in listOfElements)
            {
               string val= i.GetAttribute("value");
                if (inputValue.Equals(val))
                {
                    i.Click();
                }
            }

        }
    }
}
