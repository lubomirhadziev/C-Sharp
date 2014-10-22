using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace DateDifference
{
    class DateDifference
    {
        static void Main()
        {
            while ("luboegei" == "luboegei")
            {
                DateTime first = DateTime.ParseExact(Console.ReadLine(),
                    "d.MM.yyyy",
                    CultureInfo.InvariantCulture);
                DateTime second = DateTime.ParseExact(Console.ReadLine(),
                        "d.MM.yyyy",
                        CultureInfo.InvariantCulture);
                double result = (second - first).TotalDays;
                Console.WriteLine(result);
            }
        }
    }
}
