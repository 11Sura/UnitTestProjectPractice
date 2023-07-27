using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace UnitTestProjectPractice
{
    [TestClass]
    [TestCategory("WebElementMethods")]
    public class WebElementMethods
    {
        [TestMethod]
        [TestCategory("tag name")]
        public void TagNameMethod()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://www.google.com/";
            IWebElement tag = driver.FindElement(By.Id("APjFqb"));
            string tagName = tag.TagName;
            Console.WriteLine(tagName);

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("text")]
        public void TextMethod()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://www.google.com/";
            IWebElement text = driver.FindElement(By.Id("SIvCob"));
            string printText = text.Text;
            Console.WriteLine(printText);

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("enabled")]
        public void EnabledMethod()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.instagram.com/");
            IWebElement isEnable = driver.FindElement(By.XPath("//button[@type='submit']"));
            if(isEnable.Enabled)
            {
                Console.WriteLine("Element is enabled");
            }
            else
            {
                Console.WriteLine("Element is disabled");
            }

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("selected")]
        public void SelectedMain()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            IWebElement isSelected = driver.FindElement(By.Id("keepLoggedInCheckBox"));
            if(isSelected.Selected)
            {
                Console.WriteLine("Checkbox is selected");
            }
            else
            {
                Console.WriteLine("Checkbox is not selected");
            }

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("location")]
        public void LocationMethod()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://www.google.com/";
            IWebElement locate = driver.FindElement(By.XPath("//*[name()='svg' and @class='gb_j']"));
            Point locationValue = locate.Location;
            Console.WriteLine(locationValue);

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("size")]
        public void SizeMethod()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://www.google.com/";
            IWebElement getSize = driver.FindElement(By.XPath("//div[@class='RNNXgb']"));
            Size sizeValue = getSize.Size;
            Console.WriteLine(sizeValue);

            driver.Quit();
            driver.Dispose();

        }

        [TestMethod]
        [TestCategory("displayed")]
        public void DisplayedMethod()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://www.google.com/";
            IWebElement display = driver.FindElement(By.XPath("//img[@class='lnXdpd']"));
            if(display.Displayed)
            {
                Console.WriteLine("Image is displayed");
            }
            else
            {
                Console.WriteLine("Image is not displayed");
            }

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory ("clear")]
        public void ClearMethod()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.FindElement(By.XPath("//div[@class='SDkEP']")).SendKeys("selenium");
            driver.FindElement(By.XPath("//div[@class='SDkEP']")).Clear();
            Console.WriteLine("Input is cleared");

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("send keys")]
        public void SendKeysMethod() 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.FindElement(By.XPath("//div[@class='SDkEP']")).SendKeys("selenium");
            Console.WriteLine("Input typed in search bar");

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("submit")]
        public void SubmitMethod()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            driver.FindElement(By.XPath("//button[@type='submit']")).Submit();
            Console.WriteLine("Sumbit done");
            
            //below is the code for taking input from keyboard(like Robot class in java)
            KeyboardSimulator keyboardSimulator=new KeyboardSimulator(new InputSimulator());
            keyboardSimulator.KeyPress(VirtualKeyCode.F11);

            driver.Quit();
            driver.Dispose();
        }

        [TestMethod]
        [TestCategory("click")]
        public void ClickMethod()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://www.google.com";
            driver.FindElement(By.LinkText("Gmail")).Click();
            Console.WriteLine("Clicked on the element");

            driver.Quit();
            driver.Dispose();
        }
            
    }
}
