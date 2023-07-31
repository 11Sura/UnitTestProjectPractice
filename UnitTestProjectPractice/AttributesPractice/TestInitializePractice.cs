﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UnitTestProjectPractice.AttributesPractice
{
    public class TestInitializePractice
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
    }
}
