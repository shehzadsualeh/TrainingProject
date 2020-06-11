using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    class SearchPage
    {
        ShareStateObjects sso;

        public SearchPage(ShareStateObjects _sso)
        {
            sso = _sso;
        }

        public void SearchDress(string dname)
        {
            sso.driver.FindElement(By.Id("search_query_top")).SendKeys(dname);
            sso.driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
        }

        public void SearchResultDisplayed()
        {

        }
    }
}