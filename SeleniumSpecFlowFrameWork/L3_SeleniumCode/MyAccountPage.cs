using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    class MyAccountPage
    {

        ShareStateObjects sso;

        public MyAccountPage(ShareStateObjects _sso)
        {
            sso = _sso;
        }

        By MyAccount_txt = By.XPath("//h1[text()='My account']");

        public bool IsMyAccountHeaderDisplayed()
        {
            return sso.driver.FindElement(MyAccount_txt).Displayed;
        }
    }
}
