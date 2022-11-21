using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using SeleniumDemoWithHooks.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumDemoWithHooks.Drivers
{
    public class WebDriverHelper
    {
        String BROWSERSTACK_USERNAME = "sagirajusowjanya_nICuz5";
        String BROWSERSTACK_ACCESS_KEY = "MzWQE6UXHWxGpsafMe8Q";
        String BUILD_NAME = "browserstack-build-1";
       
        public string os = String.Empty;
        string osversion = String.Empty;
        string br = String.Empty;
        string env = String.Empty;
        string _device = String.Empty;
        string _appName = String.Empty;

        IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;
        string pathBr = @"C:\Users\sowjy\source\ELMO\SeleniumDemoWithHooks\WebDriver\";

       // string ffbr = @"C:\Users\sowjy\source\ELMO\SeleniumDemoWithHooks\bin\Debug\";
        //string username = "sagirajusowjanya_nICuz5";
        //string pwdkey = "MzWQE6UXHWxGpsafMe8Q";

        public WebDriverHelper(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public IWebDriver SetUpDriver()
        {

            os = Setup.configs.OS;
            osversion = Setup.configs.OSVersion;
            br = Setup.configs.Browser;
            env = Setup.configs.Environment;
            _device = Setup.configs.DeviceName;
            _appName = Setup.configs.AppName;


            if (env.ToLower() == "local")
            {

                if (br.ToLower() == "chrome")
                {
                    ChromeOptions options_chrome = new ChromeOptions();
                    options_chrome.AddArgument("start-maximized");
                    //options.AddArgument("--headless");

                    driver = new ChromeDriver(pathBr, options_chrome);
                    _scenarioContext.Set(driver, "WebDriver");
                }
                else if (br.ToLower() == "edge")
                {
                    EdgeOptions options_edge = new EdgeOptions();
                    options_edge.AddArgument("start-maximized");
                    driver = new EdgeDriver(pathBr, options_edge);
                    _scenarioContext.Set(driver, "WebDriver");
                }
                else if (br.ToLower() == "firefox")
                {
                    //FirefoxOptions options_firefox = new FirefoxOptions();
                    //options_firefox.AddArgument("start-maximized");
                    //options_firefox.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                    //driver = new FirefoxDriver(options_firefox);

                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    _scenarioContext.Set(driver, "WebDriver");
                }
                else
                {
                    Console.WriteLine("No Local Browser Selected");
                }


            }
            else if(env.ToLower() == "remote" && os.ToLower() == "windows")
            {
                if (br.ToLower() == "chrome")
                {
                    ChromeOptions capabilities = new ChromeOptions();
                    capabilities.BrowserVersion = "102.0";
                    Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                    browserstackOptions.Add("platformName", os);
                   // browserstackOptions.Add("osVersion", "11");
                    browserstackOptions.Add("userName", BROWSERSTACK_USERNAME);
                    browserstackOptions.Add("accessKey", BROWSERSTACK_ACCESS_KEY);
                    browserstackOptions.Add("buildName", BUILD_NAME);
                    capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
                    driver = new RemoteWebDriver(new Uri("https://hub.browserstack.com/wd/hub/"), capabilities);
                    driver.Manage().Window.Maximize();
                    _scenarioContext.Set(driver, "WebDriver");
                }
                else if (br.ToLower() == "firefox")
                {
                    FirefoxOptions capabilities = new FirefoxOptions();
                    capabilities.BrowserVersion = "101.0";
                    Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                    browserstackOptions.Add("platformName", "Windows");
                    //browserstackOptions.Add("osVersion", "11");
                    browserstackOptions.Add("userName", BROWSERSTACK_USERNAME);
                    browserstackOptions.Add("accessKey", BROWSERSTACK_ACCESS_KEY);
                    browserstackOptions.Add("buildName", BUILD_NAME);
                    capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
                    driver = new RemoteWebDriver(new Uri("https://hub.browserstack.com/wd/hub/"), capabilities);
                    driver.Manage().Window.Maximize();
                    _scenarioContext.Set(driver, "WebDriver");
                }
                else if (br.ToLower() == "edge")
                {
                    EdgeOptions capabilities = new EdgeOptions();
                    capabilities.BrowserVersion = "latest";
                    Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                    browserstackOptions.Add("platformName", "Windows");
                   // browserstackOptions.Add("osVersion", "11");
                    browserstackOptions.Add("userName", BROWSERSTACK_USERNAME);
                    browserstackOptions.Add("accessKey", BROWSERSTACK_ACCESS_KEY);
                    browserstackOptions.Add("buildName", BUILD_NAME);
                    capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
                    driver = new RemoteWebDriver(new Uri("https://hub.browserstack.com/wd/hub/"), capabilities);
                    driver.Manage().Window.Maximize();
                    _scenarioContext.Set(driver, "WebDriver");
                }              
            }
            else if (env.ToLower() == "remote" && os.ToLower() == "mac")
            {
                if (br.ToLower() == "chrome")
                {
                    ChromeOptions capabilities = new ChromeOptions();
                    capabilities.BrowserVersion = "102.0";
                    Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                    browserstackOptions.Add("platformName", os);
                    // browserstackOptions.Add("osVersion", "11");
                    browserstackOptions.Add("userName", BROWSERSTACK_USERNAME);
                    browserstackOptions.Add("accessKey", BROWSERSTACK_ACCESS_KEY);
                    browserstackOptions.Add("buildName", BUILD_NAME);
                    capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
                    driver = new RemoteWebDriver(new Uri("https://hub.browserstack.com/wd/hub/"), capabilities);
                    driver.Manage().Window.Maximize();
                    _scenarioContext.Set(driver, "WebDriver");
                }
                else if (br.ToLower() == "firefox")
                {
                    FirefoxOptions capabilities = new FirefoxOptions();
                    capabilities.BrowserVersion = "101.0";
                    Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                    browserstackOptions.Add("platformName", os);
                    //browserstackOptions.Add("osVersion", "11");
                    browserstackOptions.Add("userName", BROWSERSTACK_USERNAME);
                    browserstackOptions.Add("accessKey", BROWSERSTACK_ACCESS_KEY);
                    browserstackOptions.Add("buildName", BUILD_NAME);
                    capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
                    driver = new RemoteWebDriver(new Uri("https://hub.browserstack.com/wd/hub/"), capabilities);
                    driver.Manage().Window.Maximize();
                    _scenarioContext.Set(driver, "WebDriver");
                }
                
                else if (br.ToLower() == "safari")
                {
                    SafariOptions capabilities = new SafariOptions();
                    capabilities.BrowserVersion = "15.0";
                    Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                    browserstackOptions.Add("platformName", os);
                    // browserstackOptions.Add("osVersion", "Monterey");
                    browserstackOptions.Add("userName", BROWSERSTACK_USERNAME);
                    browserstackOptions.Add("accessKey", BROWSERSTACK_ACCESS_KEY);
                    browserstackOptions.Add("buildName", BUILD_NAME);
                    capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
                    driver = new RemoteWebDriver(new Uri("https://hub.browserstack.com/wd/hub/"), capabilities);
                    driver.Manage().Window.Maximize();
                    _scenarioContext.Set(driver, "WebDriver");
                }
            }
            else if (env.ToLower() == "remote" && os.ToLower() == "android")
            {
                if (br.ToLower() == "chrome")
                {
                    ChromeOptions capabilities = new ChromeOptions();
                    Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                    browserstackOptions.Add("osVersion", osversion);
                    browserstackOptions.Add("deviceName", _device);
                    browserstackOptions.Add("userName", BROWSERSTACK_USERNAME);
                    browserstackOptions.Add("accessKey", BROWSERSTACK_ACCESS_KEY);
                    browserstackOptions.Add("buildName", BUILD_NAME);
                    capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
                    driver = new RemoteWebDriver(new Uri("https://hub.browserstack.com/wd/hub/"), capabilities);
                    driver.Manage().Window.Maximize();
                    _scenarioContext.Set(driver, "WebDriver");
                }
                else if (br.ToLower() == "firefox")
                {
                    FirefoxOptions capabilities = new FirefoxOptions();
                    capabilities.BrowserVersion = "101.0";
                    Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                    browserstackOptions.Add("platformName", "Windows");
                    //browserstackOptions.Add("osVersion", "11");
                    browserstackOptions.Add("userName", BROWSERSTACK_USERNAME);
                    browserstackOptions.Add("accessKey", BROWSERSTACK_ACCESS_KEY);
                    browserstackOptions.Add("buildName", BUILD_NAME);
                    capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
                    driver = new RemoteWebDriver(new Uri("https://hub.browserstack.com/wd/hub/"), capabilities);
                    driver.Manage().Window.Maximize();
                    _scenarioContext.Set(driver, "WebDriver");
                }
               
            }
            else if (env.ToLower() == "remote" && os.ToLower() == "ios")
            {
                if (br.ToLower() == "chrome")
                {
                    ChromeOptions capabilities = new ChromeOptions();
                    capabilities.BrowserVersion = "102.0";
                    Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                    browserstackOptions.Add("platformName", os);
                    // browserstackOptions.Add("osVersion", "11");
                    browserstackOptions.Add("userName", BROWSERSTACK_USERNAME);
                    browserstackOptions.Add("accessKey", BROWSERSTACK_ACCESS_KEY);
                    browserstackOptions.Add("buildName", BUILD_NAME);
                    capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
                    driver = new RemoteWebDriver(new Uri("https://hub.browserstack.com/wd/hub/"), capabilities);
                    driver.Manage().Window.Maximize();
                    _scenarioContext.Set(driver, "WebDriver");
                }
                
                else if (br.ToLower() == "safari")
                {
                    SafariOptions capabilities = new SafariOptions();
                    capabilities.BrowserVersion = "15.0";
                    Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                    browserstackOptions.Add("platformName", "MAC");
                    // browserstackOptions.Add("osVersion", "Monterey");
                    browserstackOptions.Add("userName", BROWSERSTACK_USERNAME);
                    browserstackOptions.Add("accessKey", BROWSERSTACK_ACCESS_KEY);
                    browserstackOptions.Add("buildName", BUILD_NAME);
                    capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
                    driver = new RemoteWebDriver(new Uri("https://hub.browserstack.com/wd/hub/"), capabilities);
                    driver.Manage().Window.Maximize();
                    _scenarioContext.Set(driver, "WebDriver");
                }
            }
           

                return driver;

            }

    }
}
