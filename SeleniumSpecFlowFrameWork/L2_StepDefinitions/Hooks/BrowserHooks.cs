using OpenQA.Selenium.Chrome;
using SeleniumSpecFlowFrameWork.Global;
using System;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions.Hooks
{
    [Binding]
    public class BrowserHooks
    {
        ShareStateObjects sso;

        public BrowserHooks(ShareStateObjects _sso)
        {
            sso = _sso;
        }

        [BeforeScenario]
        public void Setup()
        {

            sso.driver = new ChromeDriver();
            sso.driver.Url = DataHooks.EnvData["baseurl"];
            int time = Int32.Parse(DataHooks.EnvData["default_time"]);
            sso.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
            sso.driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TearDown()
        {
            sso.driver.Quit();
        }
    }
}
