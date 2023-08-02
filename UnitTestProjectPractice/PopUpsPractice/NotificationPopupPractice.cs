using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.PopUpsPractice
{
    [TestClass]
    [TestCategory("pop up")]
    public class NotificationPopupPractice
    {

        [TestMethod]
        public void NotificationPopupMain()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.yatra.com/";
            driver.Close();
            driver.Dispose();
        }
    }
}
