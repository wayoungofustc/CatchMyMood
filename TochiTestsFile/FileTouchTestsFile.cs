using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tochi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tochi.TestsFile
{
    [TestClass()]
    public class FileTouchTestsFile
    {
        [TestMethod()]
        public void GetFileToStringSetTestFile()
        {
            string[] TestString;
            FileTouch fileTouch = new FileTouch();
            TestString = FileTouch.GetFileToStringSet(@"A:\data\MoodAs2.txt");          
            List<int> mylist = new List<int>();
            mylist = FileTouch.WashDataFromStringToInt(TestString[1]);
            foreach (int item in mylist)
            {
                Console.WriteLine(item);
            }
        }
        [TestMethod()]
        public void TestForStringPaste()
        {
            string myStringHead = @"A:\data\MoodAs";
            int myname = 1;
            string myStringTail = ".txt";
            string final = "";
            final = myStringHead +myname.ToString() +myStringTail;
            Console.WriteLine(final);
            
        }
        [TestMethod()]
        public void TestForStringToInt()
        {
            string year= "2018";
            int num = 201;
            num = int.Parse(year);
            if (num!=2018)
            {
                Assert.Fail();
                Console.WriteLine(year);
            }
            Console.WriteLine(year);
        }
    }
}