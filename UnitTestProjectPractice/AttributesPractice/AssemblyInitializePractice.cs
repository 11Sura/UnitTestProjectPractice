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
    public class AssemblyInitializePractice

    {
        public static TestContext testContext;
        public TestContext TestContextVar 
        {
            get { return testContext; }
            set { testContext = value; }
        }
        
        [TestMethod]
        [TestCategory("textcontext")]
        public void Test1Main()
        {
            TestContextVar.WriteLine(TestContextVar.TestName);
            TestContextVar.WriteLine(TestContextVar.Properties["Browser"].ToString());
        }
        
        [AssemblyInitialize]
        public static void AssemblyInitializeMain(TestContext testContext1)
        {
           // testContext = testContext1;
            MessageBox.Show("This is Assembly Initialize");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanupMain()
        {
            MessageBox.Show("This is Assembly Cleanup");
        }
    }
}
