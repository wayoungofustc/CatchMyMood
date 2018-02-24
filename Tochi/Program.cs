using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Tochi
{
    class Program
    {
        static void Main(string[] args)
        {

            WashDataToFile(@"A:\data\out.txt");
            //GetFileToStringSetTestFile();
        }
        public static void WashDataToFile(string myPath)
        {
            string[] TestString;
            List<int> myIntList = new List<int>() { 2, 4, 6, 8 };
            List<DataPoint> myDataPoint = new List<DataPoint>();

            foreach (int item in myIntList)
            {
                string temp = @"A:\data\MoodAs" + item.ToString() + ".txt";
                TestString = FileTouch.GetFileToStringSet(temp);

                for (int i = 0; i < TestString.Length; i++)
                {
                    DataPoint dataPoint = new DataPoint(TestString[i],item);
                    myDataPoint.Add(dataPoint);
                    //Console.WriteLine(dataPoint.ToString());


                }
            }
            myDataPoint.Sort();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(myPath))
            {
                foreach (DataPoint item in myDataPoint)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    file.WriteLine(item.ToString());
                }
            }


        }
    }
    
}
