using MobileAppAutomation.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;

using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace MobileAppAutomation.Drivers
{
    public class IOSDriverHelper
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
  
        ScenarioContext _scenarioContext;
        IOSDriver<IOSElement> driver;


        public IOSDriverHelper(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public IOSDriver<IOSElement> SetUpIOSDriver()
        {

            os = Setup.configs.OS;
            osversion = Setup.configs.OSVersion;
            br = Setup.configs.Browser;
            env = Setup.configs.Environment;
            _device = Setup.configs.DeviceName;
            _appName = Setup.configs.AppName;


            AppiumOptions caps = new AppiumOptions();


            // Set your BrowserStack access credentials
            caps.AddAdditionalCapability("browserstack.user", "sagirajusowjanya_nICuz5");
            caps.AddAdditionalCapability("browserstack.key", "MzWQE6UXHWxGpsafMe8Q");

            // Set URL of the application under test
            //caps.AddAdditionalCapability("id", "me.amitburst.HackerNewsiOS");
            caps.AddAdditionalCapability("app", "bs://444bd0308813ae0dc236f8cd461c02d3afa7901d");

            // Specify device and os_version
            caps.AddAdditionalCapability("device", "iPhone 11 Pro");
            caps.AddAdditionalCapability("os_version", "13");

            // Specify the platformName
            caps.PlatformName = "iOS";

            // Set other BrowserStack capabilities
            caps.AddAdditionalCapability("project", "First iOS project");
            caps.AddAdditionalCapability("build", "iOS");
            caps.AddAdditionalCapability("name", "Testing");

            // Initialize the remote Webdriver using BrowserStack remote URL
            // and desired capabilities defined above
            driver = new IOSDriver<IOSElement>(
                new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);
            _scenarioContext.Set(driver, "iOSDriver");
            return driver;

                 
        }

   
    }
}
