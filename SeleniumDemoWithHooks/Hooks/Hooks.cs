using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
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
    public class Hooks
    {

        ScenarioContext _scenarioContext;
        public Hooks(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;


        [BeforeScenario]
        public void BeforeScenario()
        {
            WebDriverHelper _helper = new WebDriverHelper(_scenarioContext);
            _scenarioContext.Set(_helper, "SeleniumDriver");

        }

        [AfterScenario]
        public void AfterScenario()
        {
            _scenarioContext.Get<IWebDriver>("WebDriver").Quit();
        }
    }
}
