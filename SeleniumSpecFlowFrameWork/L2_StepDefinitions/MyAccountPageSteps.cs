using NUnit.Framework;
using SeleniumSpecFlowFrameWork.Global;
using SeleniumSpecFlowFrameWork.L3_SeleniumCode;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions
{
    [Binding]
    class MyAccountPageSteps
    {
        ShareStateObjects sso;

        public MyAccountPageSteps(ShareStateObjects _sso)
        {
            sso = _sso;
        }

        [Then(@"I should be on my accounts page")]
        public void ThenIShouldBeOnMyAccountsPage()
        {            
            bool myAccountHeader = new MyAccountPage(sso).IsMyAccountHeaderDisplayed();
            Assert.IsTrue(myAccountHeader);
        }
    }
}
