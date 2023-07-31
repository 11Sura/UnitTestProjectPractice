using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UnitTestProjectPractice
{
    [TestClass]
    public class Report
    {
        [TestMethod]
        [TestCategory("newTest")]
        public void TestMethod01()
        {
            MessageBox.Show("This is a newTest");
        }
    }
}
