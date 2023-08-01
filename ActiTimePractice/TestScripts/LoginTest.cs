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

[assembly: Parallelize(Workers = 5, Scope=ExecutionScope.MethodLevel)]   //for parallel execution
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
       // [Ignore]                       //used to skip the test method
       public void LoginMethod()
        {
            LoginPage loginPage=new LoginPage(driver);
            HomePage homePage=new HomePage(driver);
            WebactionsLibrary webactionsLibrary = new WebactionsLibrary();
            ExcelLibrary excelLibrary = new ExcelLibrary();

            string username = excelLibrary.ExcelDataMethod("ActiTime", 1, 0);
            string password = excelLibrary.ExcelDataMethod("ActiTime", 1, 1);

            loginPage.Login(username,password);
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
        [DoNotParallelize]             //excludes method from parallel execution
        public void TasksMethod()
        {
            LoginPage loginPage = new LoginPage(driver);
            HomePage homePage = new HomePage(driver);
            WebactionsLibrary webactionsLibrary = new WebactionsLibrary();
            ExcelLibrary excelLibrary = new ExcelLibrary();

            string username = excelLibrary.ExcelDataMethod("ActiTime", 1, 0);
            string password = excelLibrary.ExcelDataMethod("ActiTime", 1, 1);

            loginPage.Login(username, password);
            Console.WriteLine("Logged into the application");
            
            By taskTabLocator = homePage.GetTaskTab();
            webactionsLibrary.WaitForElement(driver, taskTabLocator);
            homePage.TasksClick();
            Console.WriteLine("Clicked on tasks tab");
            By logoutLinkLocator=homePage.GetLogoutLink();
            webactionsLibrary.WaitForElement(driver, logoutLinkLocator);
            homePage.Logout();
            Console.WriteLine("Logged out of the application");

        }
        


    }
}
