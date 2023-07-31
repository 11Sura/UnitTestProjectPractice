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
        [AssemblyInitialize]
        public static void AssemblyInitializeMain(TestContext testContext)
        {
            MessageBox.Show("This is Assembly Initialize");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanupMain()
        {
            MessageBox.Show("This is Assembly Cleanup");
        }
    }
}
