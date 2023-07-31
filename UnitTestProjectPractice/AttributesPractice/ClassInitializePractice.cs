using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UnitTestProjectPractice.AttributesPractice
{
    [TestClass]
    [TestCategory("initialize")]
    public class ClassInitializePractice:TestInitializePractice
    {
        [ClassInitialize]
        public static void ClassInitializeMain(TestContext testContext) 
        {
            MessageBox.Show("This is Class Initialize");
        }

        [TestMethod]
        [TestCategory("initialize example")]
        public void ExampleMain()
        {
            MessageBox.Show("This is main method");
        }


        [ClassCleanup]
        public static void ClaaCleanupMain()
        {
            MessageBox.Show("This is Class Cleanup");
        }
    }
}
