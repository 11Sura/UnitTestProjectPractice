using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiTimePractice.GenericLibrary
{
    public class BaseLibrary
    {
       public IWebDriver driver;
        [TestInitialize] 
        public void InitializeMethod() 
        { 
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            string url = "https://demo.actitime.com/login.do";
            driver.Navigate().GoToUrl(url);
        }

        [TestCleanup]
        public void CleanupMethod()
        {   
            driver.Quit();
            driver.Dispose();
        }
    }
}
