using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileAppAutomation.MobPage
{
    public class AndroidPage
    {

        protected AndroidDriver<AndroidElement> _driver;
        public AndroidPage(AndroidDriver<AndroidElement> dr)
        {
            this._driver = dr;
        }


        //Page Elements

        public AndroidElement searchElement => (AndroidElement)new WebDriverWait(
                  _driver, TimeSpan.FromSeconds(30)).Until(
                  SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                      MobileBy.AccessibilityId("Search Wikipedia"))
              );

        public AndroidElement insertTextElement => (AndroidElement)new WebDriverWait(
             _driver, TimeSpan.FromSeconds(30)).Until(
             SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                 MobileBy.Id("org.wikipedia.alpha:id/search_src_text"))
         );



        public IReadOnlyList<AndroidElement> allTextViewElements =>
            _driver.FindElementsByClassName("android.widget.TextView");

        

        //Page Actions
        public void ClickOnSearch() => searchElement.Click();

        public void EnterSearchKey(string key) => insertTextElement.SendKeys(key);
    }

}
