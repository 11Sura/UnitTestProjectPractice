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
    public class CalendarPopupPractice
    {
        [TestMethod]
        public void CalendarPopupMain()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://www.hyrtutorials.com/p/calendar-practice.html";
            driver.FindElement(By.Id("first_date_picker")).Click();
            driver.FindElement(By.XPath("//a[.='26']")).Click();
            Thread.Sleep(1000);
            driver.Close();
            driver.Dispose();
        }
    }
}
