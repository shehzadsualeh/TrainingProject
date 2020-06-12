using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using System;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    class CreateAnAccountPage
    {
        ShareStateObjects sso;
        public CreateAnAccountPage(ShareStateObjects _sso)
        {
            sso = _sso;
        }

        public void CreateNewUserInfo(string fname, string lname, string password)
        {
            // sso.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            // sso.driver.FindElement(By.Id("customer_firstname")).SendKeys(fname);
            // sso.driver.FindElement(By.Id("customer_lastname")).SendKeys(lname);
            // sso.driver.FindElement(By.Id("passwd")).SendKeys(password);
        }

    }
}
