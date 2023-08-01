using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.AttributesPractice
{
    [TestClass]
   
    [TestCategory("priority")]
    public class PriorityPractice
    {
       
        [TestMethod]
        [Priority(3)]
        public void PriorityMain1()
        {
            Console.WriteLine("first method");
        }

        [TestMethod]
        [Priority(0)]
        public void PriorityMain2()
        {
            Console.WriteLine("second method");
        }

        [TestMethod]
        [Priority(2)]
        public void PriorityMain3()
        {
            Console.WriteLine("third method");
        }

        [TestMethod]
        [Priority(1)]
        public void PriorityMain4()
        {
            Console.WriteLine("fourthmethod");
        }
    }
}
