using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProjectPractice
{
    [TestClass]
    
    public class UnitTest1
       
    {
        [TestMethod]
        [TestCategory("practice1")]
        public void TestMethod1()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url="https://www.google.com/";
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            IWebElement searchTextbox = driver.FindElement(By.Id("twotabsearchtextbox"));
            searchTextbox.SendKeys("royal canin");
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
        }

        [TestMethod]
        [TestCategory("practice2")]
        public void TestMethod2()
        {
            IWebDriver driver=new ChromeDriver();
            
        }
    }
}
