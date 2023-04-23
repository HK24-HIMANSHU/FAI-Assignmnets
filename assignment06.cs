using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HimanshuAssignments
{
    class assignment06
    {
        static void Main(string[] args)
        {
            int date = UIconsole.GetInt("Enter date");
            int month = UIconsole.GetInt("Enter month");
            int year = UIconsole.GetInt("Enter year");
            Console.WriteLine(isValidDate(year, month, date));

        }
        static Boolean isValidDate(int year, int month, int day)
        {
            if ((month < 12 && month > 1) && (day>1 && day<=31))
            {
                if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) &&
                    day > 1 && day <= 31)
                    return true;
                if ((month == 4 || month == 6 || month == 9 || month == 11) &&
                   day > 1 && day <= 30)
                    return true;
                if ((month == 2) &&
                   day > 1 && day <=28)
                    return true;
            }
            return false;
        }
    }
}
