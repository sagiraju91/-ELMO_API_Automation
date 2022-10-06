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

        public WebDriverHelper(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public IWebDriver SetUpDriver(string browserName)
        {
            if (browserName.ToLower()=="chrome") {

                ChromeOptions options_chrome = new ChromeOptions();
                options_chrome.AddArgument("start-maximized");
                //options.AddArgument("--headless");
                string pathChrome = @"C:\Users\sowjy\source\ELMO\SeleniumDemoWithHooks\WebDriver\chromedriver.exe";
                driver = new ChromeDriver(pathChrome, options_chrome);                           
            }
            else if (browserName.ToLower()=="edge")
            {
                EdgeOptions options_edge = new EdgeOptions();
                options_edge.AddArgument("start-maximized");
                string pathEdge = @"C:\Users\sowjy\source\ELMO\SeleniumDemoWithHooks\WebDriver\msedgedriver.exe";
                driver = new EdgeDriver(pathEdge, options_edge);
                
            }
            _scenarioContext.Set(driver, "WebDriver");
            return driver;
            
        }

        
    }
}
