using System;
using System.Diagnostics;

namespace KofiguracjaDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // DatetimeModification();
            // DateTimeFormatting();
            // TimeMeasurment();
            // DateTimeHelpers();
        }

        static void DatetimeModification()
        {
            DateTime now = DateTime.Now;
            DateTime openDate = new DateTime(1992,6,7);

            TimeSpan result = now - openDate;
            Console.WriteLine(result.Days);
            Console.WriteLine(result.TotalDays);
            DateTime expiresAt = now.AddDays(7); // token wygasający za 7 dni
            DateTime expiresAt2 = now.Add(new TimeSpan(7, 1, 0, 0));

            Console.WriteLine(expiresAt);
            Console.WriteLine(expiresAt2);

            bool expiresAtTheSameDay = expiresAt.Date== expiresAt2.Date; // odniesienie się do propetry date



        }
        static void DateTimeFormatting()  //format daty
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToString("g"));
            Console.WriteLine(now.ToString("G"));
            Console.WriteLine(now.ToString("yyyy-MM-dd hh:mm:ss"));
        }
        static void TimeMeasurment()   // mierzenie czasu w jakim user odpowie na pytanie
        {
            Console.WriteLine("what is 2+2 ?");
            Console.WriteLine("A) 4");
            Console.WriteLine("B) 6");
            Console.WriteLine("C) 8");
            DateTime start = DateTime.Now;
            Stopwatch stopwatch = Stopwatch.StartNew();
            

#pragma warning disable CS8600 // Konwertowanie literału null lub możliwej wartości null na nienullowalny typ.
            string userAnswear = Console.ReadLine();
#pragma warning restore CS8600 // Konwertowanie literału null lub możliwej wartości null na nienullowalny typ.
            stopwatch.Stop();
            DateTime end = DateTime.Now;
            TimeSpan responseTime = end - start;
            Console.WriteLine($"Response took you {responseTime.TotalSeconds} Seconds ");
            Console.WriteLine($"Response took you {stopwatch.Elapsed.TotalSeconds} Seconds "); // elapsed - ile upłyneło

        }
        static void DateTimeHelpers()      //czy dany rok jest przestępny i ile dni jest w konkretnym miesiącu w danym roku kalendarzowym 
        {
            int daysInFeb2021 = DateTime.DaysInMonth(2021, 2);
           bool is2021LeapYear =  DateTime.IsLeapYear(2021); // czy jest przestepny 
            Console.WriteLine($"daysInFeb2021 : {daysInFeb2021}");
            Console.WriteLine($"is2021LeapYear : {is2021LeapYear}");




        }
    }
}