using ActiTimePractice.GenericLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiTimePractice.ObjectRepo
{
    public class TaskListPage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='title ellipsis']")]
        private IWebElement addNewBtn;

        [FindsBy(How =How.XPath, Using = "//div[@class='item createNewCustomer']")]
        private IWebElement addNewCustomerOption;

        [FindsBy(How = How.XPath, Using = "//div[@class='customerNameDiv']/input[@placeholder='Enter Customer Name']")]
        private IWebElement customerNameTextField;

        [FindsBy(How = How.XPath, Using = "//div[.='Create Customer']")]
        private IWebElement createCustomerButton;

        public By GetCustomerName()
        {
            By customerNameLocator = By.XPath("//div[@class='customerNameDiv']/input[@placeholder='Enter Customer Name']");
            return customerNameLocator;
        }

        public TaskListPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void CreateCustomer()
        {
            addNewBtn.Click();
            addNewCustomerOption.Click();
        }
        public void CustomerName(string CustomerName)
        {
            customerNameTextField.SendKeys(CustomerName);
        }

        public void CreateCustomerButton()
        {
            createCustomerButton.Click();
        }
    }
}
