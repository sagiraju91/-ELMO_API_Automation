using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumDemoWithHooks.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace SeleniumDemoWithHooks.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private const string baseUrl = "http://automationpractice.com/index.php";
        private readonly DriverHelper _driverHelper;

       public Hooks(DriverHelper dr) => _driverHelper = dr;

    

        [BeforeScenario]
        public void BeforeScenario()
        {            
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            //option.AddArgument("--headless");
            string pathChrome = @"C:\Users\sowjy\source\ELMO\SeleniumDemoWithHooks\WebDriver\";
            _driverHelper.Driver = new ChromeDriver(pathChrome, option);   
            _driverHelper.Driver.Navigate().GoToUrl(baseUrl);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Close();
        }
    }
}
