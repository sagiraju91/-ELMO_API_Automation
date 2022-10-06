using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumDemoWithHooks.Drivers;
using SeleniumDemoWithHooks.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumDemoWithHooks.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly DriverHelper _driverHelper;

        //private readonly Homepage hm;
        private readonly LoginPage lp;


        public LoginSteps(DriverHelper driver)
        {
            _driverHelper = driver;
        //    hm = new Homepage(_driverHelper.Driver);
            lp = new LoginPage(_driverHelper.Driver);
        }

        [When(@"I enter user Credentials as")]
        public void WhenIEnterUserCredentialsAs(Table table)
        {
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
