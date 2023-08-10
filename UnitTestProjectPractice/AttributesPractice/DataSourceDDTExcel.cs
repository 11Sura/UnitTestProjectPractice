using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.AttributesPractice
{
    [TestClass]
    [TestCategory("data source")]
    public class DataSourceDDTExcel : AssemblyInitializePractice
    {   //filepath must always be const
        public const string excelPath = "C:\\Users\\Sushma\\CsharpVisualStudio\\UnitTestProjectPractice\\UnitTestProjectPractice\\TestData\\Vet.xlsx";

        [TestMethod]
        [DataSource("System.Data.OleDb","Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+excelPath+";Extended Properties=Excel 12.0","Vet$",DataAccessMethod.Sequential)]
        public void DataSourceExcelMain()
        {
            string name = testContext.DataRow["Name"].ToString();
            string age = testContext.DataRow["Age"].ToString();
            string species= testContext.DataRow["Species"].ToString() ;

            Console.WriteLine($"Patient is a {age} year old {species} named {name}");
        }
    }
}
