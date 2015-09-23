using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsIntervalCalculator
{
    public class MarsInterval
    {
        public MarsInterval(MarsDate dateStart, MarsDate dateEnd)
        {
            if (dateStart.CompareTo(dateEnd) > 0)
            {
                //dateStaert is greater then dateEnd
                throw new ArgumentException("DateStart must not be greater then DateEnd");
            }
            DateStart = dateStart;
            DateEnd = dateEnd;
        }

        public MarsDate DateStart { get; private set; }
        public MarsDate DateEnd { get; private set; }

    }
}
