using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiTimePractice.GenericLibrary
{
    public class ExcelLibrary
    {
        
        public string ExcelDataMethod(string name, int row, int cell)
        {
            string filename = "C:\\Users\\Sushma\\CsharpVisualStudio\\UnitTestProjectPractice\\ActiTimePractice\\TestScriptData\\ActiTimeData.xlsx";
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(filename);
            string data = spreadsheet.Workbook.Worksheets.ByName(name).Cell(row, cell).ToString();
            
            spreadsheet.Close();
            return data;
        }
    }
}
