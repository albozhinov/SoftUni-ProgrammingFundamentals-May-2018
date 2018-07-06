using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P1._1._CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workingDaysCounter = 0;
            bool isHoliday = false;


            List<DateTime> holidays = new List<DateTime>()
            {
                DateTime.ParseExact("01-01-1999", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-1999", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-1999", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-1999", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-1999", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-1999", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-1999", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-10-1999", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-1999", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-1999", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-1999", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            };

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek.ToString() == "Saturday" || i.DayOfWeek.ToString() == "Sunday")
                {
                    isHoliday = true;
                }
                for (int k = 0; k < holidays.Count; k++)
                {
                    if (holidays[k].Day == i.Day && holidays[k].Month == i.Month)
                    {
                        isHoliday = true;
                        break;
                    }
                }
                if (!isHoliday)
                {
                    workingDaysCounter++;
                }
                isHoliday = false;
            }
            Console.WriteLine(workingDaysCounter);
        }
    }
}
