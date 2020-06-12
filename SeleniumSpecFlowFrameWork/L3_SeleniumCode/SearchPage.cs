using AngleSharp.Html.Dom;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumSpecFlowFrameWork.Global;
using System;
using System.Security.Cryptography.X509Certificates;

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

        public void AddProduct(string dressName, string quantity)
        {
            sso.driver.FindElement(By.XPath("//input[@id='search_query_top']")).Clear();
            sso.driver.FindElement(By.XPath("//input[@id='search_query_top']")).SendKeys(dressName);
            sso.driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
            sso.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            Actions action = new Actions(sso.driver);
            action.MoveToElement(sso.driver.FindElement(By.XPath("//div[@class='product-container']"))).Perform();
            action.MoveToElement(sso.driver.FindElement(By.XPath("//span[text()='More']"))).Click().Perform();

            // sso.driver.FindElement(By.XPath("//input[@id='quantity_wanted']")).Click();
            sso.driver.FindElement(By.XPath("//input[@id='quantity_wanted']")).Clear();
            sso.driver.FindElement(By.XPath("//input[@id='quantity_wanted']")).SendKeys(quantity);

            sso.driver.FindElement(By.XPath("//span[text()='Add to cart']")).Click();            
            sso.driver.FindElement(By.XPath("//span[@title='Continue shopping']")).Click();            
        }

        public void CartPage()
        {            
            sso.driver.FindElement(By.XPath("//a[@title='View my shopping cart']")).Click();            
        }

        public void ProceedtoCheckout()
        {
            sso.driver.FindElement(By.XPath("//span[text()='Proceed to checkout']")).Click();
        }

        public void AddressPage()
        {
            sso.driver.FindElement(By.XPath("//span[text()='Proceed to checkout']")).Click();
        }

        public void TermsCheckbox()
        {
            sso.driver.FindElement(By.XPath("//input[@type='checkbox']")).Click();
        }

        public void ProcessCarrier()
        {
            sso.driver.FindElement(By.XPath("//button[@name='processCarrier']")).Click();
        }

        public void PaymentMethod()
        {
            sso.driver.FindElement(By.ClassName("bankwire")).Click();
        }

        public void ConfirmOrder()
        {
            sso.driver.FindElement(By.XPath("//span[text()='I confirm my order']")).Click();
        }

        public string Confirmation()
        {
            string confirmation = sso.driver.FindElement(By.XPath("//strong[text()='Your order on My Store is complete.']")).Text;                       
            return confirmation;
        }
        
    }
}