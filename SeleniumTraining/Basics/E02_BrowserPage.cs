using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using System.Threading;

namespace SeleniumTraining.Basics
{
    class E02_BrowserPage
    {
        [Test]
        public void PageDemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://newtours.demoaut.com/";
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            // for(int i=800; i>=200; i--)
            // {
            //     driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //     driver.Manage().Window.Size = new Size(i, 1080); 
            // }

            Console.WriteLine(driver.Manage().Window.Size.Width);
            // Console.WriteLine(driver.Manage().Window.Size);

            // for(int i=1056; i>=200; i--)
            // {
            //     driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //     driver.Manage().Window.Size = new Size(1936, i); 
            // }
            
             for(int i=1936, j=1056; i>=200 && j>=500; i--, j--)
             
             {
                Thread.Sleep(1);
                 driver.Manage().Window.Size = new Size(i, j); 
             }


            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            // IWebElement flights = driver.FindElement(By.LinkText("Flights"));
            // flights.Click();

            // Assignment # 1

            // string path = @"C:\Users\ShehzadAli\Desktop\Name.html";            
            // File.WriteAllText(path, driver.PageSource);
            // Console.WriteLine("text written");

            // Assignment # 3(a)

            //IWebElement logo = driver.FindElement(By.XPath("//img[@alt='Mercury Tours']"));

            //if (!logo.Displayed)
            //{
            //    Console.WriteLine("Logo is missing");
            //}

            // Assignment # 3(b)

            // Console.WriteLine(driver.FindElement(By.XPath("//a[text()='CONTACT']")).GetAttribute("href"));

            // Assignment # 3(c)

            // Console.WriteLine(driver.FindElement(By.XPath("//input[@value='Login']")).GetAttribute("alt"));

            // Assignment # 3(d)

            // Console.WriteLine(driver.FindElement(By.XPath("//input[@value='Login']")).GetAttribute("outerHTML"));

            // Assignment # 3(e)

            // Console.WriteLine(driver.FindElement(By.XPath("//div[@class='footer']")).Text);            

            // Assignment # 3(f)

            //driver.FindElement(By.XPath("//input[@name='userName']")).SendKeys("mercury");
            //driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("mercury");            
            //driver.FindElement(By.XPath("//input[@value='Login']")).Click();            

            // Assignment # 3(g)

            //if(!driver.FindElement(By.XPath("//input[@value='oneway']")).Selected)
            //{
            //    driver.FindElement(By.XPath("//input[@value='oneway']")).Click();
            //}

            // Assignment 3(h)

            //if (!driver.FindElement(By.XPath("//font[text()='Economy class ']")).Selected)
            //{
            //    driver.FindElement(By.XPath("//font[text()='Economy class ']")).Click();
            //}

            // Assignment 3(i)

            // driver.FindElement(By.XPath("//select[@name='airline']/option[text()='Unified Airlines']")).Click();       

        }
    }
}
