using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiTimePractice.GenericLibrary
{
    public class WebactionsLibrary
    {
        public void WaitImplicitly(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
        }

        public void WaitForElement(IWebDriver driver, By locator) 
        {
            WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(25));
            wait.Until(ExpectedConditions.ElementExists(locator));
        }
    }
}
