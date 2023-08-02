using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
    public class AlertPopupPractice
    {
        [TestMethod]
        public void AlertPopupMain()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.automationtesting.in/Alerts.html";
            driver.FindElement(By.XPath("//a[.='Alert with OK ']")).Click();
            driver.FindElement(By.XPath("//button[@class='btn btn-danger']")).Click();
            WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.AlertIsPresent());
            IAlert alert = driver.SwitchTo().Alert();           
            alert.Accept();
            driver.Close();
            driver.Dispose();
        }
    }
}
