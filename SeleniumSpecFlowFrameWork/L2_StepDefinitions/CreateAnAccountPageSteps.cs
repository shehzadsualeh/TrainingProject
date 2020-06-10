using SeleniumSpecFlowFrameWork.Global;
using SeleniumSpecFlowFrameWork.L2_StepDefinitions.Hooks;
using SeleniumSpecFlowFrameWork.L3_SeleniumCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions
{
    [Binding]
    class CreateAnAccountPageSteps
    {
        ShareStateObjects sso;

        public CreateAnAccountPageSteps(ShareStateObjects _sso)
        {
            sso = _sso;
        }        

        [BeforeScenario]
        [When(@"The user provides the required information and submits for registration")]
        public void WhenTheUserProvidesTheRequiredInformationAndSubmitsForRegistration()
        {
            // sso.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            string firstName = UserData.UserDataInfo["app.firstname"];
            string lastName = UserData.UserDataInfo["app.lastname"];
            string password = UserData.UserDataInfo["app.password"];
            CreateAnAccountPage createAnAccountPage = new CreateAnAccountPage(sso);
            createAnAccountPage.CreateNewUserInfo(firstName, lastName, password);


            
        }

        [Then(@"The user should be able to register successfully")]
        public void ThenTheUserShouldBeAbleToRegisterSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
