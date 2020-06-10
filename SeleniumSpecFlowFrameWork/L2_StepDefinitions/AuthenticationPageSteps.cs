using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using SeleniumSpecFlowFrameWork.L2_StepDefinitions.Hooks;
using SeleniumSpecFlowFrameWork.L3_SeleniumCode;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions
{
    [Binding]
    class AuthenticationPageSteps
    {
        ShareStateObjects sso;

        public AuthenticationPageSteps(ShareStateObjects _sso)
        {
            sso = _sso;
        }

        [When(@"I provide valid credentials and submit")]
        public void WhenIProvideValidCredentialsAndSubmit()
        {
            string username = DataHooks.EnvData["app.username"];
            string password = DataHooks.EnvData["app.password"];
            AuthenticationPage authenticationPage = new AuthenticationPage(sso);
            authenticationPage.Login(username, password);
        }

        [When(@"I provide invalid credentials and submit")]
        public void WhenIProvideInvalidCredentialsAndSubmit()
        {
            string username = DataHooks.EnvData["app.invalidusername"];
            string password = DataHooks.EnvData["app.invalidpassword"];
            AuthenticationPage authenticationPage = new AuthenticationPage(sso);
            authenticationPage.Login(username, password);
        }

        [Then(@"I should get an authentication failed error")]
        public void ThenIShouldGetAnAuthenticationFailedError()
        {
            By errorMessage_txt = By.XPath("//li[text()='Authentication failed.']");
            var messageDisplayed = sso.driver.FindElement(errorMessage_txt).Displayed;
            Assert.IsTrue(messageDisplayed);
        }

        [Given(@"The user provides email ID to create an account")]
        public void GivenTheUserProvidesEmailIDToCreateAnAccount()
        {
            AuthenticationPage authenticationPage = new AuthenticationPage(sso);
            authenticationPage.RegisterNewAccount();
        }

    }
}
