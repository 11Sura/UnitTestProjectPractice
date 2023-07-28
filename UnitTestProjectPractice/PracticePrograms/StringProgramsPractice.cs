using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectPractice.PracticePrograms
{
    [TestClass]
    public class StringProgramsPractice
    {

        [TestMethod]
        [TestCategory("repetition")]
        public void CharacterRepetition()
        {
            String str = "india";
            LinkedList<char> list = new LinkedList<char>();
            for(int i = 0; i < str.Length; i++)
            {
                list.AddLast(str[i]);
            }
            foreach(char ch in list) 
            {
                int count = 0;
                for(int i=0;i<str.Length;i++)
                {
                    if(ch == str[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(ch+" repeats "+count+" times");
            }
        }
    }
}
