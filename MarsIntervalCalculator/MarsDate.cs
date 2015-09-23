using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsIntervalCalculator
{
    public class MarsDate
    {
        public MarsDate(int hour, int minute)
        {
            if (hour < 0 || hour >= 25) throw new ArgumentException("hour must not be negetive or above 24");
            if (minute < 0 || minute >= 100) throw new ArgumentException("hour must not be negetive or above 100");
            Hour = hour;
            Minute = minute;
            MinuteFromZero = (hour * 100 + minute);
        }

        public int Hour { get; private set; }
        public int Minute { get; private set; }

        public int MinuteFromZero { get; private set; }

        public static MarsDate Parse(string hour, string minute)
        {
            int hourInt = 0;
            int minuteInt = 0;
            try
            {
                hourInt = Int32.Parse(hour);
                minuteInt = Int32.Parse(minute);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new MarsDate(hourInt, minuteInt);
        }

        public int CompareTo(MarsDate date)
        {
            if (MinuteFromZero < date.MinuteFromZero) {return -1;}
            else if (MinuteFromZero > date.MinuteFromZero){ return 1;}
            else { return 0; }
            //if (_hour < date.Hour()) return -1;
            //if (_hour > date.Hour()) return 1;
            //if (_hour == date.Hour())
            //{
            //    if (_minute < date.Minute()) return -1;
            //    if (_minute > date.Minute()) return 1;
            //    if (_minute == date.Minute()) return 0;
            //}
        }

    }
}
