using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProjectPractice
{
    [TestClass]
    [TestCategory("WebdriverMethods")]
    public class WebDriverMethods
    {
        

        [TestMethod]
        [TestCategory("url")]
        public void UrlMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            Console.WriteLine("url accessed");

            driver.Quit();
            driver.Dispose();

        }

        [TestMethod]
        [TestCategory("title")]
        public void TitleMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            string title = driver.Title;
            Console.WriteLine(title);

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("page source")]
        public void PageSourceMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            string pageSource = driver.PageSource;
            Console.WriteLine(pageSource);

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("current window handle")]
        public void CurrentWindowHandleMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            string windowHandle = driver.CurrentWindowHandle;
            Console.WriteLine(windowHandle);

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("window handles")]
        public void WindowHandlesMethod() 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://secure.indeed.com/";
            driver.FindElement(By.Id("apple-signin-button")).Click();
            driver.FindElement(By.Id("login-facebook-button")).Click();
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            foreach (string handle in windowHandles)
            {
                Console.WriteLine(handle);
            }

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("close")]
        public void CloseMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            Thread.Sleep(2000);
            driver.Close();
            Console.WriteLine("Browser Closed");

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("quit")]
        public void QuitMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://secure.indeed.com/";
            driver.FindElement(By.Id("apple-signin-button")).Click();
            driver.FindElement(By.Id("login-facebook-button")).Click();
            Thread.Sleep(2000);
            driver.Quit();
            Console.WriteLine("All windows closed");

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("manage")]
        public void ManageMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Console.WriteLine("Maximized the browser");

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("navigate")]
        public void NavigateMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            Console.WriteLine("navigated to amazon.in");
           
            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("switch to")]
        public void SwitchToMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://secure.indeed.com/");
            driver.FindElement(By.Id("apple-signin-button")).Click();
            driver.SwitchTo().Frame(0);
            driver.Close();
            Console.WriteLine("Switched window");

            driver.Quit();
            driver.Dispose();
        }
        

    }
}
