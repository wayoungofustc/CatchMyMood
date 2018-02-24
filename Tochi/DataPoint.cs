using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tochi
{
    public class DataPoint: IComparer,IComparable
    {
        public long _TimeOfPoint { get; set; }
        public int _ValueOfPoint { get; set; }
        //public DateTime _dateTime { get; set; }

        public DataPoint(long TimeOfPoint,int ValueOfPoint)
        {
            this._TimeOfPoint = TimeOfPoint;
            this._ValueOfPoint = ValueOfPoint;
        }

        public DataPoint(string TimeOfPointString,int ValueOfPoint)
        {
            List<int> myIntList = new List<int>();
            myIntList = FileTouch.WashDataFromStringToInt(TimeOfPointString);
            DateTime dateTime = new DateTime(myIntList[0], myIntList[1], myIntList[2], myIntList[3], myIntList[4], myIntList[5]);
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            this._TimeOfPoint = (long)(dateTime - startTime).TotalMilliseconds;
            this._ValueOfPoint = ValueOfPoint;
        }

        public override string ToString()
        {
            return _TimeOfPoint + "\t" + _ValueOfPoint;
        }

        int IComparer.Compare(object x, object y)
        {
            DataPoint dataPoint_x = x as DataPoint;
            DataPoint dataPoint_y = y as DataPoint;
            if (dataPoint_x._TimeOfPoint > dataPoint_y._TimeOfPoint)
            {
                return 1;
            }
            else if (dataPoint_x._TimeOfPoint < dataPoint_y._TimeOfPoint)
            {
                return -1;
            }
            else if (dataPoint_x._ValueOfPoint > dataPoint_y._ValueOfPoint)
            {
                return 1;
            }
            else if (dataPoint_x._ValueOfPoint < dataPoint_y._ValueOfPoint)
            {
                return -1;
            }
            else
                return 0;
        }

        int IComparable.CompareTo(object y)
        {

            DataPoint dataPoint_x = this;
            DataPoint dataPoint_y = y as DataPoint;
            if (dataPoint_x._TimeOfPoint > dataPoint_y._TimeOfPoint)
            {
                return 1;
            }
            else if (dataPoint_x._TimeOfPoint < dataPoint_y._TimeOfPoint)
            {
                return -1;
            }
            else if (dataPoint_x._ValueOfPoint > dataPoint_y._ValueOfPoint)
            {
                return 1;
            }
            else if (dataPoint_x._ValueOfPoint < dataPoint_y._ValueOfPoint)
            {
                return -1;
            }
            else
                return 0;
            throw new NotImplementedException();
        }
    }
}
