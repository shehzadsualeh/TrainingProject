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
    class CommonPageSteps
    {
        ShareStateObjects sso;

        public CommonPageSteps(ShareStateObjects _sso)
        {
            sso = _sso;
        }

        [Given(@"I navigate to the authentication page")]
        public void GivenINavigateToTheAuthenticationPage()
        {
            new CommonPage(sso).NavigateTo(DataHooks.EnvData["baseurl"]+"/index.php?controller=authentication&back=my-account");
        }

    }
}
