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
        private const string baseUrl = "http://automationpractice.com/index.php";
        ScenarioContext _scenarioContext;

        public HomeSteps(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;


        [Given(@"the Application as")]
        public void GivenTheApplicationAs(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _driver = _scenarioContext.Get<WebDriverHelper>("SeleniumDriver").SetUpDriver((string)data.Browser);
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
            hm.ClickSingInLink();
        }

        [Then(@"User Login Page should be displayed")]
        public void ThenUserLoginPageShouldBeDisplayed()
        {
            string loginPageTitle = _driver.Title;
            Console.WriteLine("Login Page Available: Ttile = " + loginPageTitle);
            Thread.Sleep(10000);
        }

    }
}
