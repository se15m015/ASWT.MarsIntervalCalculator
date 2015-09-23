using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MarsIntervalCalculator
{
    public static class MarsIntervalCalc
    {
        public static string CalculateInterval(string intervalOneDateStartString, string intervalOneDateEndString, string intervalTwoDateStartString, string intervalTwoDateEndString)
        {
            var intervalOneDateStartStrings = Regex.Split(intervalOneDateStartString, ":");
            var intervalOneDateEndStrings = Regex.Split(intervalOneDateEndString, ":");
            var intervalTwoDateStartStrings = Regex.Split(intervalTwoDateStartString, ":");
            var intervalTwoDateEndStrings = Regex.Split(intervalTwoDateEndString, ":");
            try
            {
                var intervalOneDateStart = MarsDate.Parse(intervalOneDateStartStrings[0], intervalOneDateStartStrings[1]);
                var intervalOneDateEnd = MarsDate.Parse(intervalOneDateEndStrings[0], intervalOneDateEndStrings[1]);
                var intervalTwoDateStart = MarsDate.Parse(intervalTwoDateStartStrings[0], intervalTwoDateStartStrings[1]);
                var intervalTwoDateEnd = MarsDate.Parse(intervalTwoDateEndStrings[0], intervalTwoDateEndStrings[1]);

                return MarsIntervalChecker.Check(new MarsInterval(intervalOneDateStart, intervalOneDateEnd), new MarsInterval(intervalTwoDateStart, intervalTwoDateEnd));
            }
            catch (Exception ex)
            {
                return "ERROR";
            }
        }
    }
}
