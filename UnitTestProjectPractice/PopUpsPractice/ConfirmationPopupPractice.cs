using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.PopUpsPractice
{
    [TestClass]
    [TestCategory("pop up")]
    public class ConfirmationPopupPractice
    {
        [TestMethod]
        public void ConfirmationPopupMain()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.automationtesting.in/Alerts.html";
            driver.FindElement(By.XPath("//a[.='Alert with OK & Cancel ']")).Click();
            driver.FindElement(By.XPath("//button[@class='btn btn-primary']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.AlertIsPresent());
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            alert.Dismiss();
            driver.Close();
            driver.Dispose();
        }
    }
}

