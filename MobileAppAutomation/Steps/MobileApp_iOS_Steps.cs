using MobileAppAutomation.Drivers;
using MobileAppAutomation.MobPage;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace MobileAppAutomation.Steps
{
    [Binding]
    class MobileApp_iOS_Steps
    {
        IOSDriver<IOSElement> driver;
        iOSPage _iOS;
        ScenarioContext _scenarioContext;

        public MobileApp_iOS_Steps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"iOS Mob App")]
        public void GivenIOSMobApp()
        {
            driver = _scenarioContext.Get<IOSDriverHelper>("iOSDriver").SetUpIOSDriver();

        }

        [When(@"iOS App is Opened")]
        public void WhenIOSAppIsOpened()
        {
             _iOS = new iOSPage(driver);
            _iOS.ClickonTextBtn();
            _iOS.SendText("hello@browserstack.com" + "\n");

            Assert.AreEqual(_iOS.textOutput.Text, "hello@browserstack.com");
            

        }

        [Then(@"it should display IOS page")]
        public void ThenItShouldDisplayIOSPage()
        {
            driver.CloseApp();
        }

    }
}
