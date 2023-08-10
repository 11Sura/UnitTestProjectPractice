using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.AttributesPractice
{
    [TestClass]
    [TestCategory("data source")]
    public class DataSourceDDT :AssemblyInitializePractice
    {  
        //csv filepath must always be const
       public const string csvPath = "C:\\Users\\Sushma\\CsharpVisualStudio\\UnitTestProjectPractice\\UnitTestProjectPractice\\TestData\\Book.csv";
       
        [TestMethod] //below given is the connection string          //path  //csv file name extention is given with#
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",csvPath,"Book#csv",DataAccessMethod.Sequential)]
        public void DataSourceCsvMain()
        {
            Console.WriteLine($"Book name is: {testContext.DataRow[0]}");            //column number or column name can be provided in DataRow
            Console.WriteLine($"Price is: {testContext.DataRow["PRICE"]} rupees");      //column name string is not case sensitive
            Console.WriteLine($"Author of the book is: {testContext.DataRow[2]}");
        }                                                      
        
    }
}
