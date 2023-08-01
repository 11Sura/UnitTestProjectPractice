using ActiTimePractice.GenericLibrary;
using ActiTimePractice.ObjectRepo;
using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiTimePractice.TestScripts
{
    [TestClass]
    [TestCategory("data driven")]
    public class DataDrivenLogin:BaseLibrary
    {
        [TestMethod]
        [DynamicData(nameof(LoginData), DynamicDataSourceType.Method)]
        public void DataDrivenLoginMain(string username, string password)
        {
           // Console.WriteLine($"username is {username} and password is {password}");
            LoginPage loginPage=new LoginPage(driver);
            loginPage.Login(username, password);

        }


        public static IEnumerable<object[]> LoginData()
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile("C:\\Users\\Sushma\\CsharpVisualStudio\\UnitTestProjectPractice\\ActiTimePractice\\TestScriptData\\ActiTimeData.xlsx");
            int lastRow = spreadsheet.Workbook.Worksheets.ByName("ActiTime").UsedRangeRowMax;
            Worksheet sheetName = spreadsheet.Workbook.Worksheets["ActiTime"];

            for(int i = 1; i <=lastRow; i++)
            {
                string username = sheetName.Cell(i, 0).ToString();
                string password = sheetName.Cell(i, 1).ToString();
                yield return new object[] { username, password };
            }
            
        }

    }
}
