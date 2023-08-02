using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.TestScripts_02Aug2023
{
    [TestClass]
    [TestCategory("A")]    //while executing category, priority is not taken into consideration it executes on ascii values
                             //if trait is chosen as priority then it will be executed based on priority
    public class PriorityExample1
    {
        [TestMethod]
        [Priority(0)]
        public void TestMethod1()
        {
            Console.WriteLine("first");
            Thread.Sleep(2000);
        }
        
        [TestMethod]
        [Priority(2)]
        public void TestMethod2() 
        {
            Console.WriteLine("second");
            Thread.Sleep(2000);
        }
       
        [TestMethod]
        [Priority(1)]
       // [Ignore]             //this method will be skipped when this attribute is used
        public void TestMethod3()
        {
            Console.WriteLine("third");
            Thread.Sleep(2000);
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod4()
        {
            Console.WriteLine("fourth");
            Thread.Sleep(2000);
        }
    }
}
