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
    public class AndroidDriverHelper
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
        AndroidDriver<AndroidElement> driver;
        private readonly ScenarioContext _scenarioContext;
      


        public AndroidDriverHelper(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public AndroidDriver<AndroidElement> SetUpAndroidDriver()
        {

            os = Setup.configs.OS;
            osversion = Setup.configs.OSVersion;
            br = Setup.configs.Browser;
            env = Setup.configs.Environment;
            _device = Setup.configs.DeviceName;
            _appName = Setup.configs.AppName;



            //AppiumOptions caps = new AppiumOptions();
            //// Set your BrowserStack access credentials
            //caps.AddAdditionalCapability("userName", BROWSERSTACK_USERNAME);
            //caps.AddAdditionalCapability("accessKey", BROWSERSTACK_ACCESS_KEY);
            //// Set URL of the application under test
            //caps.AddAdditionalCapability("app", "bs://c700ce60cf13ae8ed97705a55b8e022f13c5827c");
            //// Specify device and os_version
            //caps.AddAdditionalCapability("device", _device);
            //caps.AddAdditionalCapability("os_version", osversion);
            //// Specify the platform name
            //caps.PlatformName = os;
            //// Set other BrowserStack capabilities
            //caps.AddAdditionalCapability("project", "CSharp MobileApp");
            //caps.AddAdditionalCapability("build", "browserstack-build-1");
            //caps.AddAdditionalCapability("name", BUILD_NAME);
            //// Initialize the remote Webdriver using BrowserStack remote URL
            //// and desired capabilities defined above
            //driver = new AndroidDriver<AndroidElement>(
            //       new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);

            AppiumOptions caps = new AppiumOptions();
            // Set your BrowserStack access credentials
            caps.AddAdditionalCapability("browserstack.user", "sagirajusowjanya_nICuz5");
            caps.AddAdditionalCapability("browserstack.key", "MzWQE6UXHWxGpsafMe8Q");
            // Set URL of the application under test
            caps.AddAdditionalCapability("app", "bs://c700ce60cf13ae8ed97705a55b8e022f13c5827c");
            // Specify device and os_version
            caps.AddAdditionalCapability("device", "Google Pixel 3");
            caps.AddAdditionalCapability("os_version", "9.0");
            // Specify the platform name
            caps.PlatformName = "Android";
            // Set other BrowserStack capabilities
            caps.AddAdditionalCapability("project", "First CSharp project");
            caps.AddAdditionalCapability("build", "browserstack-build-1");
            caps.AddAdditionalCapability("name", "first_test");
            // Initialize the remote Webdriver using BrowserStack remote URL
            // and desired capabilities defined above
            driver = new AndroidDriver<AndroidElement>(
                    new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);
            _scenarioContext.Set(driver, "AndroidDriver");

            return driver;

            
        }

    
    }
}
