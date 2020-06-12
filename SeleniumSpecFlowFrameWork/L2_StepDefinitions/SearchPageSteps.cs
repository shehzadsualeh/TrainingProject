using SeleniumSpecFlowFrameWork.Global;
using SeleniumSpecFlowFrameWork.L3_SeleniumCode;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions
{

    [Binding]
    class SearchPageSteps
    {
        ShareStateObjects sso;

        public SearchPageSteps(ShareStateObjects _sso)
        {
            sso = _sso;
        }

        [When(@"The user searches for (.*)")]
        public void WhenTheUserSearchesFor(string p0)
        {
            SearchPage searchPage = new SearchPage(sso);
            searchPage.SearchDress(p0);
        }

        [Then(@"The user should be able to see all results with (.*)")]
        public void ThenTheUserShouldBeAbleToSeeAllResultsWith(string p0)
        {

        }
    }
}