using MobileAppAutomation.Drivers;
using MobileAppAutomation.MobPage;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace MobileAppAutomation.Steps
{
    [Binding]
    class MobileApp_Android_Steps
    {
        AndroidDriver<AndroidElement> _driver;
        AndroidPage _android;        
        ScenarioContext _scenarioContext;

        public MobileApp_Android_Steps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;            
        }


        [Given(@"Android Mob App")]
        public void GivenAndroidMobApp()
        {
            _driver = (AndroidDriver<AndroidElement>)_scenarioContext.Get<AndroidDriverHelper>("AndroidDriver").SetUpAndroidDriver();
            
        }


        [When(@"Opened")]
        public void WhenOpened()
        {
            //_android = new AndroidPage(_driver);

            // _android.SearchClick();
            //_android.InsertText("BrowserStack");

            AndroidElement searchElement = (AndroidElement)new WebDriverWait(
                _driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                    MobileBy.AccessibilityId("Search Wikipedia"))
            );
            searchElement.Click();
            AndroidElement insertTextElement = (AndroidElement)new WebDriverWait(
                _driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                    MobileBy.Id("org.wikipedia.alpha:id/search_src_text"))
            );
            insertTextElement.SendKeys("BrowserStack");
            Thread.Sleep(5000);

            IReadOnlyList<AndroidElement> allTextViewElements =
                _driver.FindElementsByClassName("android.widget.TextView");
            Console.WriteLine(allTextViewElements.Count > 0);
            Thread.Sleep(5000);
        }



        [Then(@"the should be displayed")]
        public void ThenTheShouldBeDisplayed()
        {
            //_android.getElements();

            _driver.CloseApp();
        }

    }
}
