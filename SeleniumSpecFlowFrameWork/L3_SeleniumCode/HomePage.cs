using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumSpecFlowFrameWork.Global;

namespace SeleniumSpecFlowFrameWork.L3_SeleniumCode
{
    class HomePage
    {
        
        ShareStateObjects sso;
        public HomePage(ShareStateObjects _sso)
        {
            sso = _sso;
        }
        
        public void PopularDress(string dress)
        {
            Actions action = new Actions(sso.driver);
            action.MoveToElement(sso.driver.FindElement(By.XPath("(//a[@class='product_img_link'])[2]"))).Perform();
            action.MoveToElement(sso.driver.FindElement(By.XPath("(//a[@title='Add to cart'])[2]"))).Click().Perform();
        }


    }
}
