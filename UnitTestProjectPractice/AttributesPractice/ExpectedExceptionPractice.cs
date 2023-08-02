using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.AttributesPractice
{
    [TestClass]
    public class ExpectedExceptionPractice
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]       //the type of exception must be specified here
        public void ExpectedExceptionsMain()
        {
            int[] a = { 2, -4, 23, 5 };
            for(int i=0; i<=a.Length; i++)       //index is out of bounds, so exception expected here
            {
                Console.WriteLine(a[i]);
            }

        }

    }
}
