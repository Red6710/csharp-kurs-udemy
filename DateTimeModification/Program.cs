using System.Diagnostics;
using System.Xml.Serialization;

namespace DateTimeModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTimeModification();
            //TimeMeasurement();
            //DateTimeFormatting();
            DateTimeHelpers();
        }
    

    static void DateTimeModification()
        {
            DateTime now = DateTime.Now;
            DateTime openDate = new DateTime(1992, 6, 17);
            TimeSpan result = now - openDate;
            Console.WriteLine(result.Days);
            Console.WriteLine(result.TotalDays);

            DateTime expiresAt = now.AddDays(7);
            DateTime expiresAt2 = now.Add(new TimeSpan(7, 1, 0, 0));

            Console.WriteLine(expiresAt);
            Console.WriteLine(expiresAt2);


            bool expiresAtTheSameDay = expiresAt.Date == expiresAt2.Date;
            Console.WriteLine(expiresAtTheSameDay);


        }
        static void DateTimeFormatting()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToString("dd-MM-yyyy hh:mm:ss"));
        }

        static void TimeMeasurement()
        {
            Console.WriteLine("What is 2+2 ?");
            Console.WriteLine("A)4");
            Console.WriteLine("B)6");
            Console.WriteLine("B)68");

            DateTime start = DateTime.Now;

            Stopwatch stopwatch = Stopwatch.StartNew();
            
            string userAnswer = Console.ReadLine();

            stopwatch.Stop();

            DateTime emd = DateTime.Now;
            TimeSpan responseTime = emd - start;

            Console.Write(stopwatch.Elapsed.TotalSeconds);


        }

        static void DateTimeHelpers()
        {
            int daysInFeb = DateTime.DaysInMonth(2021, 2);
            bool is2021LeapYear = DateTime.IsLeapYear(2021);
            Console.WriteLine(daysInFeb);
            Console.WriteLine(is2021LeapYear);

        }
    } 
}
