using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.TestScripts_02Aug2023
{
    [TestClass]
    public class ScreenshotPractice
    {
        [TestMethod]
        public void ScreenshotMain()
        {
            IWebDriver driver= new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Url = "https://www.google.com";
            ITakesScreenshot takesScreenshot = (ITakesScreenshot) driver;
            Screenshot source = takesScreenshot.GetScreenshot();                                       //provide name(eg: browser.png) along with path
            source.SaveAsFile("C:\\Users\\Sushma\\CsharpVisualStudio\\UnitTestProjectPractice\\UnitTestProjectPractice\\Screenshots\\browser.png", ScreenshotImageFormat.Png);
        }
    }
}
