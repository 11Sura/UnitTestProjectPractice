using ActiTimePractice.GenericLibrary;
using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ActiTimePractice
{
    [TestClass]
    public class UnitTest1:ExcelLibrary
    {
        [TestMethod]
        [TestCategory("excel")]
        public void TestMethod1()

        {
            ExcelLibrary library = new ExcelLibrary();  
            for(int i = 0; i < 3; i++)
            {
                string data = library.ExcelDataMethod("ActiTime", 0, i);
                Console.WriteLine(data);
            }
        }
    }
}
