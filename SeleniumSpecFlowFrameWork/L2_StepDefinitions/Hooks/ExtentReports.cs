﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Support.Extensions;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions.Hooks
{
    [Binding]
    public class ExtentHooks
    {
        [ThreadStatic]
        private static ExtentTest featureName;
        private ExtentTest scenario;
        private static ExtentReports extent;

        private readonly ScenarioContext scenarioContext;
        private ShareStateObjects sso;

        public ExtentHooks(ScenarioContext _scenarioContext, ShareStateObjects sso)
        {
            scenarioContext = _scenarioContext;
            this.sso = sso;
            //  sso.scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void StartReporting()
        {
            string dir = DateTime.Now.ToString("ddMMyyyy_HHmmss");
            string reportdir = @"C:\Users\ShehzadAli/" + dir;
            Directory.CreateDirectory(reportdir);

            // create ExtentReports and attach reporter(s)
            extent = new ExtentReports();
            var reporter = new ExtentHtmlReporter(reportdir + "/");
            extent.AttachReporter(reporter);

            var reporterv3 = new ExtentV3HtmlReporter(reportdir + "/ev3.html");
            extent.AttachReporter(reporterv3);
        }

        [BeforeFeature]
        public static void Setup(FeatureContext featureContext)
        {

            //featureName=ExtentService.Instance.CreateTest<Feature>(featureContext.FeatureInfo.Title);
            featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void Beforescenario()
        {

            scenario = featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
            //scenario =ExtentTestManager.GetTest().CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);
        }

        [AfterStep]
        public void LogSteps()
        {
            string gherkinKeyWord = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string gherkinStep = scenarioContext.StepContext.StepInfo.Text;

            switch (scenarioContext.ScenarioExecutionStatus)
            {
                case ScenarioExecutionStatus.OK:
                    scenario.CreateNode<Given>("<i>" + gherkinKeyWord + "</i>" + "  " + gherkinStep);
                    break;

                case ScenarioExecutionStatus.TestError:
                    string ss = sso.driver.TakeScreenshot().AsBase64EncodedString;
                    scenario.CreateNode<Given>("<i>" + gherkinKeyWord + "</i>" + "  " + gherkinStep).
                        Fail("<i><font color = \"red\">" + scenarioContext.TestError.Message + "</font></i>", MediaEntityBuilder.CreateScreenCaptureFromBase64String(ss).Build());
                    break;

                case ScenarioExecutionStatus.StepDefinitionPending:
                    scenario.CreateNode<Given>("<i>" + gherkinKeyWord + "</i>" + "  " + gherkinStep).Warning("<i><font color=\"orange\"> Step Definition Pending</font></i>");
                    break;
            }
        }

        [AfterTestRun]
        protected static void TearDown()
        {
            extent.AddSystemInfo("OS", "Win 10"); // hard coded at the moment; can fetch dynamically.
            extent.AddSystemInfo("Browser", "Chrome 83");
            extent.Flush();
        }
    }
}