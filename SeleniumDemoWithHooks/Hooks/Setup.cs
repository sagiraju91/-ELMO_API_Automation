using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using SeleniumDemo.configurations;
using SeleniumDemoWithHooks.Drivers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
//[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace SeleniumDemoWithHooks.Hooks
{
    [Binding]
    public  class Setup
    {
        private static ExtentTest fetureName;
        private static ExtentTest scenarioName;
        private static ExtentReports extent;
        public static string ReportPath;

        private static string _path = System.IO.Path.GetFullPath(@"..\..\..\");
        private static string _brConfigPath = String.Empty;
        private static string _extentPath = String.Empty;
        public static string os = String.Empty;
        public static string osversion = String.Empty;
        public static string br = String.Empty;
        public static string env = String.Empty;
        public static string _appName = String.Empty;

        ScenarioContext _scenarioContext;
        public static BrConfigSettings configs;
        public Setup(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            fetureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            Console.WriteLine("Test Name : "+ fetureName);
        }



        [BeforeScenario]
        public void BeforeScenario()
        {
            scenarioName = fetureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            Console.WriteLine("Test Node : " + scenarioName);

            
                WebDriverHelper _helper = new WebDriverHelper(_scenarioContext);
                _scenarioContext.Set(_helper, "SeleniumDriver");
            
        }


        [BeforeTestRun]
        public static void BeforeTestRun()
        {

            _brConfigPath = Path.Combine(_path, @"configurations\Config.json");
            configs = new BrConfigSettings();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(_brConfigPath);
            IConfigurationRoot _iConfig = builder.Build();
            _iConfig.Bind(configs);


            os = Setup.configs.OS;
            osversion = Setup.configs.OSVersion;
            br = Setup.configs.Browser;
            env = Setup.configs.Environment;
            _appName = Setup.configs.AppName;
            _extentPath = Path.Combine(_path, @"Reports\TestResults.html");
            ExtentHtmlReporter _htmlReporter = new ExtentHtmlReporter(_extentPath);
            _htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(_htmlReporter);
            extent.AddSystemInfo("Host Name:", "Sowjanya-PC");
            extent.AddSystemInfo("Environment:","Pre-Prod");
            extent.AddSystemInfo("UserName:", "Sowjanya");
            extent.AddSystemInfo("Test Suite:", "Regression");
            extent.AddSystemInfo("OS:", os );
            extent.AddSystemInfo("OSVersion:", osversion);
            extent.AddSystemInfo("Browser:", br);
            extent.AddSystemInfo("Executed On:", env);
 
        }

        [Obsolete]
        [AfterStep]
        public void AfterReportingSteps()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                {
                    scenarioName.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (stepType == "When")
                {
                    scenarioName.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (stepType == "Then")
                {
                    scenarioName.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (stepType == "And")
                {
                    scenarioName.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
                }

            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                {
                    scenarioName.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "When")
                {
                    scenarioName.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "Then")
                {
                    scenarioName.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "And")
                {
                    scenarioName.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
            }
        }


        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
        }
        


        [AfterScenario]
        public void AfterScenario()
        {
            _scenarioContext.Get<IWebDriver>("WebDriver").Quit();
        }
    }
}
