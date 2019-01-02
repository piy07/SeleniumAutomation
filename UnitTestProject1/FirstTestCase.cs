using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1
{
    [TestClass]
    public class FirstTestCase
    {
        IWebDriver driverch;

        [TestMethod]
        public void TestMethod1()
        {
            driverch = new FirefoxDriver();//ChromeDriver();

            driverch.Manage().Window.Maximize();
            driverch.Navigate().GoToUrl("https://www.wikipedia.org/");
            List<String> textofanchors = new List<string>();
            ReadOnlyCollection<IWebElement> anchorList = driverch.FindElements(By.TagName("a"));
            foreach(IWebElement anchor in anchorList)
            {
                    if(anchor.Text.Length>0)
                {
                    if (anchor.Text.Contains("English"))
                    {
                        textofanchors.Add(anchor.Text);
                        anchor.Click();
                        break;
                    }
                }
               
            }
            //driver.FindElement(By.Id("searchInput")).SendKeys("google");
            //driver.FindElement(By.ClassName("svg-search-icon")).Click();
            //string abc = driver.FindElement(By.Id("firstHeading")).Text.ToString();

            driverch.Close();
            //driver.Quit();
        }
    }
}
