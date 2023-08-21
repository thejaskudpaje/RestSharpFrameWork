using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Tiger_Nunit_FW.GenericUtility
{
    public class ScreenShotClass :BaseClass
    {
        public string Save_ScreenShot()
        {
           Screenhot_path = $"G:\\TYSS\\C#\\projects\\V_Tiger_Nunit_FW\\V_Tiger_Nunit_FW\\ScreenshotsFolder\\{TestContext.CurrentContext.Test.Name}.png";
            
            ITakesScreenshot screenshotObj = (ITakesScreenshot)driver;
            var  src= screenshotObj.GetScreenshot();
            src.SaveAsFile(Screenhot_path, ScreenshotImageFormat.Png);
            return Screenhot_path;
        }
    }
}
