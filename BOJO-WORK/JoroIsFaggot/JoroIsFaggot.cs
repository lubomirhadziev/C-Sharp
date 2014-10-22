using System;
using System.Collections.Generic;
using System.Linq;
namespace JoroIsFaggot
{
    class JoroIsFaggot
    {
        static void Main()
        {
            char kindOfYear = char.Parse(Console.ReadLine());
            if (kindOfYear == 't')
            {
                int p = int.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                int defaultWeekends = 52 - h;
                int TiredWeekends = defaultWeekends / 3;
                int playableWeekends = defaultWeekends - TiredWeekends;
                double some = playableWeekends * 2 + h;
                //double Matches = playedHolidays + 3 - TiredWeekends;
                Console.WriteLine(some);
            }
            else if (kindOfYear == 'f')
            {
            }
        }
    }
}
