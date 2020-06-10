using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.StepDefinitions
{
    [Binding]
    public class Ex01_LoginSteps
    {


        [When(@"I enter valid credentials and submit")]
        public void WhenIEnterValidCredentialsAndSubmit()
        {
            Console.WriteLine("enter valid creds");
            Console.WriteLine("This is how parameter is handled");
            var s = TestContext.Parameters.Get("browser");
            Console.WriteLine(s);

        }

        [Then(@"I should be successfully logged in")]
        public void ThenIShouldBeSuccessfullyLoggedIn()
        {
            Console.WriteLine("successful login ...");
        }

        [When(@"I enter invalid credentials and submit")]
        public void WhenIEnterInvalidCredentialsAndSubmit()
        {
            Console.WriteLine("enter invalid creds");
        }

        [Then(@"I should be NOT be logged in")]
        public void ThenIShouldBeNOTBeLoggedIn()
        {
            Console.WriteLine("login unsuccessful");
        }

        [Given(@"I navigate to Login Page")]
        public void GivenINavigateToLoginPage()
        {
            Console.WriteLine("navigate to login page");
        }

    }
}
