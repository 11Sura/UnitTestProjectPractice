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
    [TestCategory("task")]
    public class CreateCustomerTest:BaseLibrary
    {
        [TestMethod]
        [TestCategory("create")]
        public void CreateCustomerMain()
        {
            LoginPage loginPage = new LoginPage(driver);
            ExcelLibrary excelLibrary = new ExcelLibrary();
            HomePage homePage = new HomePage(driver);
            WebactionsLibrary webactionsLibrary = new WebactionsLibrary();

            string username = excelLibrary.ExcelDataMethod("ActiTime", 1, 0);
            string password = excelLibrary.ExcelDataMethod("ActiTime", 1, 1);

            loginPage.Login(username, password);
            By locator = homePage.GetTaskTab();
            webactionsLibrary.WaitForElement(driver, locator);
            homePage.TasksClick();

            TaskListPage taskListPage = new TaskListPage(driver);
            taskListPage.CreateCustomer();
            By customerNameLocator = taskListPage.GetCustomerName();
            webactionsLibrary.WaitForElement(driver, customerNameLocator);

            Random random = new Random();
            int extra=random.Next(1000);

            taskListPage.CustomerName("Customer"+extra);
            taskListPage.CreateCustomerButton();

        }
    }
}
