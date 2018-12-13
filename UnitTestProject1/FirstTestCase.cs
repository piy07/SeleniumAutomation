using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class FirstTestCase
    {

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
            List<String> textofanchors = new List<string>();
            ReadOnlyCollection<IWebElement> anchorList = driver.FindElements(By.TagName("a"));
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

            driver.Close();
            //driver.Quit();
        }
    }
}
