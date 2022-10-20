using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumDemoWithHooks.Drivers
{
    public class WebDriverHelper
    {
        IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;
        string pathBr = @"C:\Users\sowjy\source\ELMO\SeleniumDemoWithHooks\WebDriver\";


        public WebDriverHelper(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public IWebDriver SetUpDriver(string browserName)
        {
            if (browserName.ToLower() == "chrome")
            {

                ChromeOptions options_chrome = new ChromeOptions();
                options_chrome.AddArgument("start-maximized");
                //options.AddArgument("--headless");                
                driver = new ChromeDriver(pathBr, options_chrome);
                _scenarioContext.Set(driver, "WebDriver");
            }
            else if (browserName.ToLower() == "edge")
            {
                EdgeOptions options_edge = new EdgeOptions();
                options_edge.AddArgument("start-maximized");
                driver = new EdgeDriver(pathBr, options_edge);
                _scenarioContext.Set(driver, "WebDriver");
            }
            else
            {
                Console.WriteLine("No Browser Selected");
            }
            _scenarioContext.Set(driver, "WebDriver");
            return driver;

        }

    }
}
