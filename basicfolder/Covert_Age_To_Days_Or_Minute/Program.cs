using System;

namespace Covert_Age_To_Days_Or_Minute
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearuser = int.Parse(Console.ReadLine());
            int Monthuser = int.Parse(Console.ReadLine());
            int dateuser = int.Parse(Console.ReadLine());
            CovertInday(yearuser , Monthuser, dateuser);
        }

        static void CovertInday(int AgeUser, int MonthUser, int DayUser)
        {
            int YearNow = DateTime.Now.Date.Year;
            int MonthNow = DateTime.Now.Date.Month;
            int DayNow = DateTime.Now.Date.Day;
            // int HourNow = DateTime.Now.Hour;
            // int MinuteNow = DateTime.Now.Minute;
            // int SecondNow = DateTime.Now.Second;

            
            int YearOfB = YearNow - AgeUser;
            int MonthOfB = MonthNow - (MonthUser - MonthNow); 
            
            
            System.Console.WriteLine((YearOfB * 12) + ( MonthUser - MonthNow)+MonthNow);
            
        }
    }
}



/*
            int Year = DateTime.Now.Date.Year;
            int Month = DateTime.Now.Date.Month;
            int Day = DateTime.Now.Date.Day;
            int Hour = DateTime.Now.Hour;
            int Minute = DateTime.Now.Minute;
            int Second = DateTime.Now.Second;
            System.Console.WriteLine($"{Year} Year {Month} Month {Day} Day {Hour} Hours {Minute} Minuite {Second} Seconde");
*/