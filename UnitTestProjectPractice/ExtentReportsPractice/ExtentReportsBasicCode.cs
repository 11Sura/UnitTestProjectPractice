using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.ExtentReportsPractice
{
    [TestClass]
    public class ExtentReportsBasicCode
    {
        //store the path of a destination file that stores the reports
        static String filepath = "C:\\Users\\Sushma\\CsharpVisualStudio\\UnitTestProjectPractice\\UnitTestProjectPractice\\ExtentReportsPractice\\ExtentReportsFile\\";

        [TestMethod]
        public void ExtentReportsBasicMain()
        {
            
            ExtentReports extentReports = new ExtentReports();     //create an object of ExtentReports class
            ExtentHtmlReporter extentHtmlReporter = new ExtentHtmlReporter(filepath);  //create an object of ExtentHtmlReports 
                                                                                       //give path of the destination as argument
            extentHtmlReporter.Start();           //start the html reporter
            extentReports.AddSystemInfo("Test Type", "Practice");   //this is to give additional info to br printed in report
            extentReports.AttachReporter(extentHtmlReporter);       //attach html report to extent reports file


            ExtentTest extentTest = extentReports.CreateTest("Extent Reports Practice");  //create a test file with the name: Extent Reports Practice
            extentTest.Log(Status.Info, "This is an extent report practice");    //Log(Status.Info)  //this and below method both work same
            extentTest.Info("This is a practice report");                        //Info   //this internally calls Log(Status. )
            
            extentTest.Log(Status.Pass, "Test Passed");
            extentTest.Log(Status.Warning, "This is a warning");
            extentTest.Log(Status.Fatal, "There is a fatal error");
            extentTest.Fail("Test Failed");
            extentTest.Error("Error detected");
            extentTest.Debug("Activate Debug");

            extentReports.Flush();    //flush the reports
            extentHtmlReporter.Stop();  //stop the previously started html reporter



        }
    }
}
