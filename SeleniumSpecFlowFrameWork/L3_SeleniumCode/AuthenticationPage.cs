using OpenQA.Selenium;
using SeleniumSpecFlowFrameWork.Global;
using System;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    public class AuthenticationPage
    {
        ShareStateObjects sso;

        public AuthenticationPage(ShareStateObjects _sso)
        {
            sso = _sso;
        }

        By Email_txt = By.Id("email");
        By Password_txt = By.Id("passwd");
        By Submit_btn = By.Id("SubmitLogin");

        public void Login(string uname, string pwd)
        {
            sso.driver.FindElement(Email_txt).SendKeys(uname);
            sso.driver.FindElement(Password_txt).SendKeys(pwd);
            sso.driver.FindElement(Submit_btn).Click();
        }

        public void ClearEmailField()
        {
            sso.driver.FindElement(Email_txt).Clear();
        }

        public void RegisterNewAccount()
        {
            Random random = new Random();
            string randomNumber = random.Next(1, 9999).ToString();
            sso.driver.FindElement(By.Id("email_create")).SendKeys("faizan" + randomNumber + "@gmail.com");
            sso.driver.FindElement(By.Id("SubmitCreate")).Click();
        }
    }
}
