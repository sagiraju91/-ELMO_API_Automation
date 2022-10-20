using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumDemoWithHooks.Drivers;
using SeleniumDemoWithHooks.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumDemoWithHooks.Steps
{
    [Binding]
    public class LoginSteps
    {
        IWebDriver _driver;
        HomePage hm;
        LoginPage lp;
        private const string baseUrl = "http://automationpractice.com/index.php";
        ScenarioContext _scenarioContext;

        public LoginSteps(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [Given(@"the Application open")]
        public void GivenTheApplicationOpen()
        {
            _driver = _scenarioContext.Get<WebDriverHelper>("SeleniumDriver").SetUpDriver("chrome");
            _driver.Url = baseUrl;
            Thread.Sleep(10000);
            hm = new HomePage(_driver);
            hm.ClickSingInLink();
        }


        [When(@"I enter user Credentials as")]
        public void WhenIEnterUserCredentialsAs(Table table)
        {
            lp = new LoginPage(_driver);
            dynamic data = table.CreateDynamicInstance();
            lp.EnterUserName(data.username);
            lp.EnterUserPassword(data.password);
        }
        [When(@"I click on Login Button")]
        public void WhenIClickOnLoginButton()
        {
            lp.ClickLoginBtn();
        }
        [Then(@"the User should be logged in successfully")]
        public void ThenTheUserShouldBeLoggedInSuccessfully()
        {
            Console.WriteLine("Verifying Sign Out Link");
            Assert.That(lp.IsExistLogout(), Is.True);

            Console.WriteLine("Verify Clicking Sign Out Link");
            lp.ClickLogOutLink();
        }

    }
}
