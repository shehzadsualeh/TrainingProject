using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

using System.Security.AccessControl;

namespace SeleniumTraining.Basics
{

    class Assignment
    {
        [Test]
        public void TestCase1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://automationpractice.com/";
            driver.FindElement(By.XPath("//a[@title='Log in to your customer account']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            var authentication = driver.FindElement(By.XPath("//span[@class='navigation_page']")).Displayed;            
            Assert.IsTrue(authentication);
            // Assert.AreEqual("Authentication", authentication);

            var num = random4DigitNumber();
            var user = "shehzad" + num + "@gmail.com";

            driver.FindElement(By.XPath("//input[@id='email_create']")).SendKeys(user);
            driver.FindElement(By.XPath("//button[@id='SubmitCreate']")).Click();           
            
            driver.FindElement(By.XPath("//div[@id='uniform-id_gender1']")).Click();
            
            driver.FindElement(By.XPath("//input[@id='customer_firstname']")).SendKeys("Shehzad");
            driver.FindElement(By.XPath("//input[@id='customer_lastname']")).SendKeys("Ali");
            var userEmail = driver.FindElement(By.XPath("//input[@id='email']")).GetAttribute("value");
            Assert.AreEqual(user, userEmail);
            
            driver.FindElement(By.XPath("//input[@id='passwd']")).SendKeys("password");
            SelectElement selectDate = new SelectElement(driver.FindElement(By.XPath("//select[@id='days']")));
            selectDate.SelectByIndex(1);
            SelectElement selectMonth = new SelectElement(driver.FindElement(By.XPath("//select[@id='months']")));
            selectMonth.SelectByIndex(5);
            SelectElement selectYear = new SelectElement(driver.FindElement(By.XPath("//select[@id='years']")));
            selectYear.SelectByValue("1990");
            
            var firstName = driver.FindElement(By.XPath("//input[@id='firstname']")).GetAttribute("value");
            Assert.AreEqual("Shehzad", firstName);
            
            var lastName = driver.FindElement(By.XPath("//input[@id='lastname']")).GetAttribute("value");
            Assert.AreEqual("Ali", lastName);
            driver.FindElement(By.XPath("//input[@id='address1']")).SendKeys("1 ABC Avenue");
            driver.FindElement(By.XPath("//input[@id='city']")).SendKeys("Bradford");

            SelectElement selectstate = new SelectElement(driver.FindElement(By.XPath("//select[@id='id_state']")));
            selectstate.SelectByText("Alabama");
            
            driver.FindElement(By.XPath("//input[@id='postcode']")).SendKeys("75300");

            SelectElement selectcountry = new SelectElement(driver.FindElement(By.XPath("//select[@id='id_country']")));
            selectstate.SelectByIndex(1);

            driver.FindElement(By.XPath("//input[@id='phone_mobile']")).SendKeys("01234567890");
            driver.FindElement(By.XPath("//input[@id='alias']")).Clear();
            driver.FindElement(By.XPath("//input[@id='alias']")).SendKeys("Na Maloom Afraad");
            driver.FindElement(By.XPath("//button[@id='submitAccount']")).Click();
            var myAccountTab = driver.FindElement(By.XPath("//span[text()='My account']")).Text;
            Assert.AreEqual("My account", myAccountTab);
        }

        public string random4DigitNumber()
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                s = String.Concat(s, random.Next(10).ToString());
            }
            return s;
        }

        [Test]
        public void TestCase2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://automationpractice.com/";
            driver.FindElement(By.XPath("//a[@title='Contact Us']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            SelectElement selectElement = new SelectElement(driver.FindElement(By.XPath("//select[@id='id_contact']")));
            selectElement.SelectByText("Customer service");
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("shehzad@msn.com");
            driver.FindElement(By.XPath("//input[@id='id_order']")).SendKeys("0123456");
            driver.FindElement(By.XPath("//textarea[@id='message']")).SendKeys("Today is a very good day");
            driver.FindElement(By.XPath("//button[@id='submitMessage']")).Click();
            var message = driver.FindElement(By.XPath("//p[@class='alert alert-success']")).Text;
            Assert.AreEqual("Your message has been successfully sent to our team.", message);
        }


        [Test]
        public void TestCase3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://automationpractice.com/";
            driver.FindElement(By.XPath("//a[@title='Log in to your customer account']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            var authentication = driver.FindElement(By.XPath("//span[@class='navigation_page']")).Displayed;
            Assert.IsTrue(authentication);
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("faizan125@hotmail.com");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Test1234");
            driver.FindElement(By.XPath("//button[@id='SubmitLogin']")).Click();
            var signInPerson = driver.FindElement(By.XPath("//a[@title='View my customer account']")).Text.Contains("Faizan Sheikh");
            Assert.IsTrue(signInPerson);
        }
    
        [Test]
        public void TestCase4()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://automationpractice.com/";
            driver.FindElement(By.XPath("//a[@title='Log in to your customer account']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//a[text()='Forgot your password?']")).Click();
            var header = driver.FindElement(By.XPath("//h1[text()='Forgot your password?']")).Text;
            Assert.AreEqual("FORGOT YOUR PASSWORD?", header);
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("faizan125@hotmail.com");
            driver.FindElement(By.XPath("//span[text()='Retrieve Password']")).Click();
            var notification = driver.FindElement(By.XPath("//p[@class='alert alert-success']")).Text;
            Assert.AreEqual("A confirmation email has been sent to your address: faizan125@hotmail.com", notification);
        }

        [Test]
        public void TestCase5()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://automationpractice.com/";
            driver.FindElement(By.XPath("//input[@id='search_query_top']")).SendKeys("Printed Dress");
            driver.FindElement(By.XPath("//button[@name='submit_search']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("(//a[@class='product_img_link'])[2]"))).Perform();
            action.MoveToElement(driver.FindElement(By.XPath("(//a[@title='Add to cart'])[2]"))).Click().Perform();
            
            driver.FindElement(By.XPath("//a[contains(.,'Proceed to checkout')]")).Click();
            driver.FindElement(By.XPath("//div[@class='columns-container']//a[@title='Proceed to checkout']")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("faizan125@hotmail.com");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Test1234");
            driver.FindElement(By.XPath("//button[@id='SubmitLogin']")).Click();
            driver.FindElement(By.XPath("//button[@name='processAddress']")).Click();
            driver.FindElement(By.XPath("//div[@class='checker']")).Click();
            driver.FindElement(By.XPath("//button[@name='processCarrier']")).Click();
            driver.FindElement(By.XPath("//a[@title='Pay by bank wire']")).Click();
            var header = driver.FindElement(By.XPath("//h1[@class='page-heading']")).Text;
            Assert.AreEqual("ORDER SUMMARY", header);
            driver.FindElement(By.XPath("//span[text()='I confirm my order']")).Click();
            var orderConfirmation = driver.FindElement(By.XPath("//strong[text()='Your order on My Store is complete.']")).Text;
            Assert.AreEqual("Your order on My Store is complete.", orderConfirmation);

            
        }
    }
}
