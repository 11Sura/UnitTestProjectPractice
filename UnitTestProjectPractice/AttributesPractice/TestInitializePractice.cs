using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UnitTestProjectPractice.AttributesPractice
{
    public class TestInitializePractice //:AssemblyInitializePractice
    {
       
        [TestInitialize]
        public void TestInitializeMain()
        {
            MessageBox.Show("This is Test Initialize");
           
        }


        [TestCleanup]
        public void TestCleanupMain()
        {
            MessageBox.Show("This is Test Cleanup");
        }
        
        /*
        //second [TestInitialize] blocks
        [TestInitialize]
        public void TestInitializeMain2()
        {
            MessageBox.Show("2nd test initialize");
        }
        [TestCleanup]
        public void TestCleanupMain2()
        {
            MessageBox.Show("2nd test cleanup");
        }
        */
        //example test method
        [TestMethod]
        [TestCategory("Btest")]
        public void MainTest()
        {
            MessageBox.Show("hello");
        }
        
    }
}
