using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.ODBC_Connection
{
    [TestClass]
    [TestCategory("database")]
    public class DatabaseExtentReport
    {
        OdbcConnection connection;                      //create a reference for OdbcConnection sealed class
        [TestMethod]
        [TestCategory("odbc")]
        public void DatabaseExtentMain()
        {                             //connection string consisting of MySQL driver, server, port number, database, username and password
            string connectionString = "Driver={MySQL ODBC 8.1 Unicode Driver};Server=rmgtestingserver:3333;Database=projects;User=root@%;Password=root;";
            connection = new OdbcConnection(connectionString);
            string query = "select * from project;";    //sql query
            connection.Open();                          //open database connection 
            OdbcCommand command = new OdbcCommand(query, connection);  //create an object of OdbcCommand by passing the SQL query and Odbc connection reference
            OdbcDataReader table = command.ExecuteReader();    //execute the query  (i.e., retriving all the data from project database)      
            Console.WriteLine(table.Read());            //to go to the next line            

            while (table.Read())                         //this condition checks line by line and returns True as long as data is present in the next line 
            {
               
                Console.WriteLine(table[0].ToString() + "   " + table[1].ToString() + "   " + table[2].ToString());

                extentTest.Log(AventStack.ExtentReports.Status.Info, table[0].ToString() + "   " + table[1].ToString() + "   " + table[2].ToString());

            }
            connection.Close();                         
        }


        

        static string filepath = "C:\\Users\\Sushma\\CsharpVisualStudio\\UnitTestProjectPractice\\UnitTestProjectPractice\\ExtentReportsPractice\\ExtentReportsFile\\";
        ExtentReports extentReports = new ExtentReports();
        ExtentHtmlReporter extentHtmlReporter = new ExtentHtmlReporter(filepath);
        ExtentTest extentTest;

        [TestInitialize]
        public  void ExtentInitializeMain()
        {
            extentHtmlReporter.Start();
            extentReports.AddSystemInfo("Test Type", "database");
            extentReports.AttachReporter(extentHtmlReporter);
            extentTest = extentReports.CreateTest("Extent Reports Practice");
        }

        [TestCleanup]
        public void ExtentCleanupMain()
        {
            extentReports.Flush();
            extentHtmlReporter.Stop();
        }


    }
}
