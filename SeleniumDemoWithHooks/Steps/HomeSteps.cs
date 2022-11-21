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
        IWebDriver _driver;
        HomePage hm;
        private const string baseUrl = "https://demo.guru99.com/test/newtours/index.php";
        ScenarioContext _scenarioContext;

        public HomeSteps(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;


        [Given(@"the Application as")]
        public void GivenTheApplicationAs()
        {
           // dynamic data = table.CreateDynamicInstance();
            _driver = _scenarioContext.Get<WebDriverHelper>("SeleniumDriver").SetUpDriver();
            _driver.Url = baseUrl;
            string pageTitle = _driver.Title;
            Console.WriteLine("Application Available: Ttile = " + pageTitle);
        }

        [When(@"Click on Signin link from HomePage")]
        public void GivenClickOnSigninLinkFromHomePage()
        {
            hm = new HomePage(_driver);

            Console.WriteLine("Verifying Sign In Link");
            Assert.That(hm.IsExistSingInLink(), Is.True);

            Console.WriteLine("Verify Clicking Sign In Link");
            hm.ClickSingOnLink();
        }

        [Then(@"User Login Page should be displayed")]
        public void ThenUserLoginPageShouldBeDisplayed()
        {
            string loginPageTitle = _driver.Title;
            Console.WriteLine("Login Page Available: Ttile = " + loginPageTitle);
            Thread.Sleep(1000);
        }

    }
}
