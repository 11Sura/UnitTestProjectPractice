using ActiTimePractice.GenericLibrary;
using ActiTimePractice.ObjectRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiTimePractice.TestScripts
{
    [TestClass]
    public class MultipleLoginTest:BaseLibrary
    {
        [TestMethod]
        [TestCategory("multiple data")]
        [DataTestMethod]
        [DataRow("admin", "manager")]
        [DataRow("trainee", "trainee")]
        public void MultipleLoginMethod(string username,string password)
        {
            LoginPage loginPage = new LoginPage(driver);
            HomePage homePage = new HomePage(driver);
            WebactionsLibrary webactionsLibrary = new WebactionsLibrary();

            loginPage.Login(username, password);
            Console.WriteLine("Logged in successfully");

            By locator = homePage.GetLogoutLink();
            webactionsLibrary.WaitForElement(driver, locator);

            homePage.Logout();
            Console.WriteLine("Logged out successfully");

        }
    }
}
