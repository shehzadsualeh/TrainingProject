using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;

namespace SeleniumTraining.Basics
{
    class Assignment3
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void Exercise1()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://the-internet.herokuapp.com/download";
            driver.FindElement(By.LinkText("log.txt")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            if (File.Exists("C:/Users/ShehzadAli/Downloads/log.txt"))
            {
                File.Delete("C:/Users/ShehzadAli/Downloads/log.txt");
            }

            else
            {
                throw new ArgumentException();
            }
        }

        [Test]
        public void Exercise2A()
        {
            // string a;
            driver.Manage().Window.Maximize();
            driver.Url = "https://the-internet.herokuapp.com/tables";
            driver.Manage().Window.Maximize();

            int columnIndex = GetColumnIndex("Web Site");
            Console.WriteLine(columnIndex);
        }

        [Test]
        public void Exercise2B()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://the-internet.herokuapp.com/tables";
            driver.Manage().Window.Maximize();

            int rowIndex = GetRowIndex("Bach");
            int columnIndex = GetColumnIndex("Due");

            var value = driver.FindElement(By.XPath("//table[@id='table1']/tbody/tr[" + rowIndex + "]/td[" + columnIndex + "]")).Text;
            Console.WriteLine(value);
        }

        public int GetRowIndex(string name)
        {
            var noOfRows = driver.FindElements(By.XPath("//table[@id='table1']/tbody/tr")).Count;
            for (int i = 1; i <= noOfRows; i++)
            {
                var rowname = driver.FindElement(By.XPath("//table[@id='table1']/tbody/tr[" + i + "]/td[1]")).Text;
                if (rowname == name)
                {
                    return i;
                }
            }
            return 0;
        }

        public int GetColumnIndex(string name)
        {
            var noOfColumns = driver.FindElements(By.XPath("//table[@id='table1']/thead/tr/th")).Count;

            for (int i = 1; i <= noOfColumns; i++)
            {
                var columnName = driver.FindElement(By.XPath("//table[@id='table1']/thead/tr/th[" + i + "]")).Text;
                if (columnName == name)
                {
                    return i;
                }
            }
            return 0;
        }

        [Test]
        public void Exercise2C(string colName, string rowValue)
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://the-internet.herokuapp.com/tables";
            int cIndex = new List<IWebElement>(driver.FindElements(By.XPath("//table[@id='table1']/thead/tr/th"))).FindIndex(x => x.Text == colName);
            int rIndex = new List<IWebElement>(driver.FindElements(By.XPath("//table[@id='table1']/tbody/tr"))).FindIndex(x => x.Text.StartsWith(rowValue));
            if (cIndex != -1 && rIndex != -1)
            Console.WriteLine(driver.FindElement(By.XPath("//table[@id='table1']/tbody/tr[" + (rIndex + 1) + "]/td[" + (cIndex + 1) + "]")).Text);
        }
    }
}
