using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Modifier
{
    public class DateModifier
    {
        public static int GerDeferenceBetweenDates(string start,string end) 
        {
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);

            TimeSpan difference = endDate - startDate;

            return Math.Abs(difference.Days);
        }
       

    }
}
