using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsIntervalCalculator
{
    public static class MarsIntervalChecker
    {
        public static string Check(MarsInterval intervalOne, MarsInterval intervalTwo)
        {
            //NESTED
            if ((intervalOne.DateStart.MinuteFromZero < intervalTwo.DateStart.MinuteFromZero &&
                intervalOne.DateEnd.MinuteFromZero > intervalTwo.DateEnd.MinuteFromZero) ||
                (intervalTwo.DateStart.MinuteFromZero < intervalOne.DateStart.MinuteFromZero &&
                intervalTwo.DateEnd.MinuteFromZero > intervalOne.DateEnd.MinuteFromZero))
            {
                return "NESTED";
            }

            //OVERLAP
            if ((intervalOne.DateStart.MinuteFromZero < intervalTwo.DateStart.MinuteFromZero &&
               intervalOne.DateEnd.MinuteFromZero < intervalTwo.DateEnd.MinuteFromZero) ||
               (intervalTwo.DateStart.MinuteFromZero < intervalOne.DateStart.MinuteFromZero &&
               intervalTwo.DateEnd.MinuteFromZero < intervalOne.DateEnd.MinuteFromZero))
            {
                return "NESTED";
            }

            //TOUCH
            if (intervalOne.DateEnd.MinuteFromZero == intervalTwo.DateStart.MinuteFromZero||
                intervalTwo.DateEnd.MinuteFromZero == intervalOne.DateStart.MinuteFromZero)
            {
                return "NESTED";
            }

            //DISJOINT
            if (intervalOne.DateEnd.MinuteFromZero < intervalTwo.DateStart.MinuteFromZero ||
                intervalTwo.DateStart.MinuteFromZero < intervalOne.DateEnd.MinuteFromZero)
            {
                return "DISJOINT";
            }

            return "ERROR";
        
       }
    }
}
