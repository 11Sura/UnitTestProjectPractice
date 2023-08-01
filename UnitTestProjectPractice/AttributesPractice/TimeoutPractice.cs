using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.AttributesPractice
{
    [TestClass]
    [TestCategory("timeout")]
    public class TimeoutPractice
    {
        [TestMethod]
        [Timeout(3000)]      //this attribute is used to set time duration for the excution of method
                             //for example, in this case the method should get executed within 3000ms, else it fails. 
        public void TimeoutMain()
        {
            IWebDriver driver=new ChromeDriver();
            Console.WriteLine("Chrome browser opened");
            Console.WriteLine("Timeout duration present");
            driver.Quit();
        }

        [TestMethod]
        
        public void Print()  //this method has no time out duration, it will execute normally
        {
            IWebDriver driver = new ChromeDriver();
            Console.WriteLine("Chrome browser opened");
            Console.WriteLine("time out not present");
            driver.Quit();
        }
    }
}
