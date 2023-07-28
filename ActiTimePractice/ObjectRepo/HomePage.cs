using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiTimePractice.ObjectRepo
{
    public class HomePage
    {
        //declaration
        [FindsBy(How = How.Id, Using = "logoutLink")]
        private IWebElement logoutLink { get; set; }

        [FindsBy(How =How.Id, Using = "container_tasks")]
        private IWebElement tasksTab { get; set; }

        //initialization
        public HomePage(IWebDriver driver) 
        {
            PageFactory.InitElements(driver, this);
        }

        public By GetTaskTab()
        {
            By locator = By.Id("container_tasks");
            return locator;
        }

        public By GetLogoutLink()
        {
            By locator = By.Id("logoutLink");
            return locator;
        }

        //business logic
        public void TasksClick()
        {
            tasksTab.Click();
        }
        public void Logout()
        {
            logoutLink.Click();
        }

    }
}
