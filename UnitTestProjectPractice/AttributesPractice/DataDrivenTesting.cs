using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.AttributesPractice
{
    [TestClass]
    public class DataDrivenTesting
    {
        [TestMethod]
        [TestCategory("data driven")]
        [DataTestMethod]
        [DataRow("A")]
        [DataRow("B")]
        [DataRow("C")]
        [DataRow("D")]
        public void DataDrivenMain(String alphabet)
        {
            Console.WriteLine(alphabet);

        }
    }
}
