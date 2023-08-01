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
            By taskTabLocator = By.Id("container_tasks");
            return taskTabLocator;
        }

        public By GetLogoutLink()
        {
            By logoutLinkLocator = By.Id("logoutLink");
            return logoutLinkLocator;
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
