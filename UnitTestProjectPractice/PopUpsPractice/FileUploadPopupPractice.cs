using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.PopUpsPractice
{
    [TestClass]
    [TestCategory("pop up")]
    public class FileUploadPopupPractice
    {
        [TestMethod]
        public void FileUploadMain()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "file:///C:/Users/Sushma/Desktop/c%23Documents/Upload.html";
            string path = "C:/Users/Sushma/Desktop/c#Documents/DummyFile.docx";   //provide absolute path
            driver.FindElement(By.Id("cv")).SendKeys(path);
        }
    }
}

//the above code is written for a webpage that is created using the html code: <input type="file" id="cv"/>
//the url provided above belongs to the created webpage