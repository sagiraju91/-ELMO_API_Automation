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
        private const string baseUrl = "https://demo.guru99.com/test/newtours/index.php";
        ScenarioContext _scenarioContext;

        public LoginSteps(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;
        
        [Given(@"the Application open as")]
        public void GivenTheApplicationOpenAs()
        {
           // dynamic data = table.CreateDynamicInstance();
            _driver = _scenarioContext.Get<WebDriverHelper>("SeleniumDriver").SetUpDriver();
            _driver.Url = baseUrl;
            //Thread.Sleep(3000);
            hm = new HomePage(_driver);
            hm.ClickSingOnLink();            
        }

        [When(@"I enter user Credentials as")]
        public void WhenIEnterUserCredentialsAs(Table table)
        {
            lp = new LoginPage(_driver);
            dynamic data = table.CreateDynamicInstance();
            
            try
            {
                Thread.Sleep(10000);
                IAlert _alert = _driver.SwitchTo().Alert();
                _alert.Dismiss();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //lp.ClickOnPopup();
            lp.EnterUserName(data.username);
            lp.EnterUserPassword(data.password);

        }
        [When(@"I click on Login Button")]
        public void WhenIClickOnLoginButton()
        {
            lp.ClickLoginBtn();
            Thread.Sleep(1000);
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
