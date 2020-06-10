using SeleniumSpecFlowFrameWork.Global;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    class CommonPage
    {
        ShareStateObjects sso;

        public CommonPage(ShareStateObjects _sso)
        {
            sso = _sso;
        }
        public void NavigateTo(string url)
        {
            sso.driver.Navigate().GoToUrl(url);
        }
    }
}
