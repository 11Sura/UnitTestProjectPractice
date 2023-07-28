using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ActiTimePractice.ObjectRepo
{
    public class LoginPage
    {
        //declaration of webelements
        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement usenameTextBox { get; set; }

        [FindsBy(How = How.Name, Using = "pwd")]
        private IWebElement passwordTextBox { get; set; }

        [FindsBy(How =How.Id, Using = "loginButton")]
        private IWebElement loginBtn { get; set; }

        //initialization of webelements
        
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

       

        //business logic
        public void Login(string username,string password)
        {
            usenameTextBox.SendKeys(username);
            Thread.Sleep(2000);
            passwordTextBox.SendKeys(password);
            Thread.Sleep(2000);
            loginBtn.Click();
        }
    }
}
