using ActiTimePractice.GenericLibrary;
using ActiTimePractice.ObjectRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ActiTimePractice.TestScripts
{
    [TestClass]
    public class LoginTest:BaseLibrary
    {
        /// <summary>
        /// This ia a test method for login action
        /// </summary>
        [TestMethod]
        [TestCategory("login")]
        [Ignore]
       public void LoginMethod()
        {
            LoginPage loginPage=new LoginPage(driver);
            HomePage homePage=new HomePage(driver);
            WebactionsLibrary webactionsLibrary = new WebactionsLibrary();


            loginPage.Login("admin","manager");
            Console.WriteLine("Logged into the application");

            By locator=homePage.GetLogoutLink();
            webactionsLibrary.WaitForElement(driver,locator);

            homePage.Logout();
            Console.WriteLine("Logged out of the application");

        }
        /// <summary>
        /// This is a test method to click on tasks tab in home page
        /// </summary>
        [TestMethod]
        [TestCategory("tasks")]
        public void TasksMethod()
        {
            LoginPage loginPage = new LoginPage(driver);
            HomePage homePage = new HomePage(driver);
            WebactionsLibrary webactionsLibrary = new WebactionsLibrary();

            loginPage.Login("admin","password");
            Console.WriteLine("Logged into the application");
            
            By locator = homePage.GetTaskTab();
            webactionsLibrary.WaitForElement(driver,locator);
            homePage.TasksClick();
            Console.WriteLine("Clicked on tasks tab");
            webactionsLibrary.WaitImplicitly(driver);
            homePage.Logout();
            Console.WriteLine("Logged out of the application");

        }
        


    }
}
