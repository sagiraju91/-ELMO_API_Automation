using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumDemoWithHooks.Drivers;
using SeleniumDemoWithHooks.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumDemoWithHooks.Steps
{
    [Binding]
    public class HomeSteps
    {
        private readonly DriverHelper _driver;

        private readonly HomePage hm;
      
        public HomeSteps(DriverHelper driver)
        {
            _driver = driver;
            hm = new HomePage(_driver.Driver);

        }

        [Given(@"the Application open")]
        public void GivenTheApplicationOpen()
        {
            string pageTitle= _driver.Driver.Title;
            Console.WriteLine("Application Available: Ttile = "+ pageTitle);
        }

        [When(@"Click on Signin link from HomePage")]
        public void GivenClickOnSigninLinkFromHomePage()
        {
            Console.WriteLine("Verifying Sign In Link");
            Assert.That(hm.IsExistSingInLink(), Is.True);

            Console.WriteLine("Verify Clicking Sign In Link");
            hm.ClickSingInLink();
        }

        [Then(@"User Login Page should be displayed")]
        public void ThenUserLoginPageShouldBeDisplayed()
        {
            string loginPageTitle = _driver.Driver.Title;
            Console.WriteLine("Login Page Available: Ttile = " + loginPageTitle);
            Thread.Sleep(10000); 
        }

    }
}
