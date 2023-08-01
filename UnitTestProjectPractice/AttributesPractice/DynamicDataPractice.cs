using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.AttributesPractice
{
    [TestClass]
    [TestCategory("data driven")]
    public class DynamicDataPractice
    {
        [TestMethod]
        [DynamicData(nameof(VetData),DynamicDataSourceType.Method)]
        public void DynamicDataMain(string name, string age, string species)
        {
            Console.WriteLine($"Patient {name} is a {age} years old {species}");
        }

        //below code is used to fetch data from external resource file(excel file)
        //this code must be written within the same class as test method
        public static IEnumerable<Object[]> VetData()
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile("C:\\Users\\Sushma\\CsharpVisualStudio\\UnitTestProjectPractice\\UnitTestProjectPractice\\TestData\\Vet.xlsx");
            int lastrow = spreadsheet.Workbook.Worksheets.ByName("Vet").UsedRangeRowMax;
            Worksheet sheetName = spreadsheet.Workbook.Worksheets["Vet"];

            for(int i = 1; i <= lastrow; i++)
            {
                string name = sheetName.Cell(i, 0).ToString();
                string age = sheetName.Cell(i, 1).ToString();
                string species = sheetName.Cell(i, 2).ToString();   
                yield return new Object[] { name, age, species };
            }
        }
    }
}
