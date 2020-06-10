using AjaxControlToolkit.HtmlEditor.ToolbarButtons;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTraining.Basics
{
    class Assignment2
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void Exercise1()
        {            
            driver.Manage().Window.Maximize();
            driver.Url = "https://dojo.github.io/examples/widget-showcase/";
            driver.FindElement(By.XPath("//div[text()='Selects']")).Click();
            var header = driver.FindElement(By.XPath("//h2[text()='Select Widgets']")).Displayed;
            Assert.IsTrue(header);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//div[@class='select-m__inputWrapper__2BMKU']")).Click();
            driver.FindElement(By.XPath("//div[@class='select-m__root__26Kq_ select-m__focused__TIg6n']//div[text()='baz']")).Click();
            var baz = driver.FindElement(By.XPath("//button[@class='select-m__trigger__2s_Ja']")).Text;
            Assert.AreEqual("baz", baz);            
        }

        [Test]
        public void Exercise2()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://dojotoolkit.org/reference-guide/1.9/dijit/layout/TabContainer-examples.html";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//div[@id='programmatic-nested-tabs']//a[@title='Run Example']")).Click();

            // Tried explicit wait, unable to use it

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.XPath("//div[@widgetid='tabContainer_tablist_dijit_layout_TabContainer_1']")));

            // Thread.Sleep(30000);            

            // driver.SwitchTo().Frame(0);
            // driver.FindElement(By.XPath("//div[@widgetid='tabContainer_tablist_dijit_layout_TabContainer_1']")).Click();
            var text = driver.FindElement(By.XPath("//div[text()='Vivamus orci massa rhoncus a lacinia']")).Displayed;
            Assert.IsTrue(text);            
        }

        [Test]
        public void Exercise3()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "http://clauderic.github.io/react-sortable-hoc/#/basic-configuration/basic-usage?_k=9i27ow";
            var dragFrom = driver.FindElement(By.XPath("//div[text()='0']"));
            var dragTo = driver.FindElement(By.XPath("//div[text()='1']"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(dragFrom).ClickAndHold().MoveToElement(dragTo).Release().Build().Perform();
            var text1 = driver.FindElement(By.XPath("(//div[@class='Showcase__style__item Showcase__style__stylizedItem'])[1]")).Text;
            Assert.AreEqual("Item 1", text1);
            var text2 = driver.FindElement(By.XPath("(//div[@class='Showcase__style__item Showcase__style__stylizedItem'])[2]")).Text;
            Assert.AreEqual("Item 0", text2);            
        }

        [Test]
        public void Exercise4()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://the-internet.herokuapp.com/entry_ad";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            // Thread.Sleep(10000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//div[@class='modal']//p[text()='Close']")));
            driver.FindElement(By.XPath("//div[@class='modal']//p[text()='Close']")).Click();            
        }

        [Test]
        public void Exercise5()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.selenium.dev/selenium/docs/api/java/";
            driver.SwitchTo().Frame(2);
            driver.FindElement(By.XPath("//div[@class='topNav']//a[text()='Help']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame("packageFrame");
            driver.FindElement(By.XPath("//a[@href='org/openqa/selenium/interactions/Actions.html']")).Click();            
        }
    }
}
