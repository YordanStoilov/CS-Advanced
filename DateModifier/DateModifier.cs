using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class DateModifier
    {
        public static int CalculateDifferenceBetweenTwoDates(string dateOne, string dateTwo)
        {
            string[] date1 = dateOne.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] date2 = dateTwo.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[] date1asInt = date1.Select(int.Parse).ToArray();
            int[] date2asInt = date2.Select(int.Parse).ToArray();

            DateTime firstDate = new DateTime(date1asInt[0], date1asInt[1], date1asInt[2]);
            DateTime secondDate = new DateTime(date2asInt[0], date2asInt[1], date2asInt[2]);

            return Math.Abs((int)(secondDate - firstDate).TotalDays);
        }
    }
}
