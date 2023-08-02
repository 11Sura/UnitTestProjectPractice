using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V85.WebAuthn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.PopUpsPractice
{
    [TestClass]
    [TestCategory("pop up")]
    public class AuthenticationPopupPractice
    {
        [TestMethod]
        public void AuthenticationPopupMain()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Navigate().GoToUrl("https://admin:admin@the-internet.herokuapp.com/basic_auth");
            
        }
       
    }
}
