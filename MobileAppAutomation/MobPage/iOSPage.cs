using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileAppAutomation.MobPage
{
    public class iOSPage
    {

        protected IOSDriver<IOSElement> _driver;
        public iOSPage(IOSDriver<IOSElement> dr)
        {
            this._driver = dr;
        }


        //Page Elements
        public IOSElement textButton => (IOSElement)new WebDriverWait(_driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.AccessibilityId("Text Button"))
            );
        
            public IOSElement textInput => (IOSElement)new WebDriverWait(_driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.AccessibilityId("Text Input"))
            );
        

           public  IOSElement textOutput => (IOSElement)new WebDriverWait(_driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.AccessibilityId("Text Output"))
            );

        

        

            public void ClickonTextBtn() => textButton.Click();
            public void SendText(string input) => textInput.SendKeys(input);



    }


}
