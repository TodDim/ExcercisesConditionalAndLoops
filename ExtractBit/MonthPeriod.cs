using System;

namespace MonthPeriod
{
    class MonthPeriod
    {
        static string Getmonth(int month)
        {
            string monthName;
            switch (month)
            {
                case 1:
                    monthName = "qnuari"; break;
                case 2:
                    monthName = "fevruari"; break;
                case 3:
                    monthName = "mart"; break;
                case 4:
                    monthName = "april"; break;
                case 5:
                    monthName = "mai"; break;
                case 6:
                    monthName = "iuni"; break;
                case 7:
                    monthName = "iuli"; break;
                case 8:
                    monthName = "avgust"; break;
                case 9:
                    monthName = "septemvri"; break;
                case 10:
                    monthName = "oktomvri"; break;
                case 11:
                    monthName = "noemvri"; break;
                case 12:
                    monthName = "dekemvri"; break;
                default:
                    Console.WriteLine("nqma takyv"); return null;
            }
            return monthName;
        }
        static void SayPeriod(int startmonth, int endmonth)
        {
            int period = endmonth - startmonth;
            if (period < 0)
            {
                period = period + 12;
            }
            Console.WriteLine("There is a {0} months period from {1} to {2}.", period, Getmonth(startmonth), Getmonth(endmonth));
        }
        static void Main()
        {
            Console.WriteLine("vyvedi 1-vi mesec");
            int startmonth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("vyvedi 2-ri mesec");
            int endmonth = Int32.Parse(Console.ReadLine());
            SayPeriod(startmonth, endmonth);
        }
    }
}

    

