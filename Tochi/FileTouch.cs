using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace Tochi
{
    public class FileTouch
    {
        public static string[] GetFileToStringSet(string path)
        {
            List<string> Lines = new List<string>();
            string[] MyStringSet = System.IO.File.ReadAllLines(path);
            return MyStringSet;
        }
        // Return Int
        public static List<int> WashDataFromStringToInt(string MyString)
        {
            string pattern = @"(\d{4}).(\d{1,2}).(\d{1,2}).{8}(\d{2}):(\d{2}):(\d{2})";
            List<int> MydatePara=new List<int>();

            MatchCollection matches;
            matches= Regex.Matches(MyString,pattern);
            foreach (Match item in matches)
            {
                for (int i = 1; i < item.Groups.Count; i++)
                {
                    MydatePara.Add(int.Parse(item.Groups[i].Value));
                }
            }
            return MydatePara;
        }
    }
}
