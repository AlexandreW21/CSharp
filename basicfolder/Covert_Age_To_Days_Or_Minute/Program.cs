using System;

namespace Covert_Age_To_Days_Or_Minute
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime curentTime = DateTime.Now;

            System.Console.WriteLine($"Pls right your date of birth \n The syntax is:  {curentTime}");

            string DOBUser = Console.ReadLine();  // input user DOB

            char[] deliniter = {' ', ':', '/', '\t'};       // carater splite 
            string[] stringUserdob =  DOBUser.Split(deliniter);    // array of the user DOB
            int[] userdob = Array.ConvertAll(stringUserdob, S => int.Parse(S)); // convert  all the array int string
            // int dateuser = userdob[0];
            // int monthuser = userdob[1];
            // int yearuser = userdob[2];
            // int houruser = userdob[3];
            // int minuser = userdob[4];
            

            int totalday = 0;
            int totalInMinute = 0;
            

            for(var a = userdob[2]; a < curentTime.Year; a = a + 4)   // add the extra day of the Leap year  == 366 day 
            {
                totalday ++;
            }
            totalday += (userdob[2] * 365);

            //calcule the number of day in this current year 
            for (var D = 0; D <= userdob[1] -1 ; D++)  
            {
                if (D == 2) // February has 28 days
                {
                    totalday = totalday + 28;
                }
                if (D == 1 || D  == 3 || D  == 5 || D  ==  7 || D  == 8 || D  == 10 || D  == 12) //january, March, May, July, August, October, and December have 31 days
                {
                    totalday = totalday + 31;
                }
                if (D == 4 || D  == 6 || D  == 9 || D  ==  11) // April, June, September, and November have 30 days
                {
                    totalday = totalday + 30;
                }                
            }
            for (var h = 0; h < userdob[3] ; h++)
            {
                totalInMinute ++;
            } 
            foreach (var item in userdob)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine(totalday);
            System.Console.WriteLine(totalInMinute);

            

            

           

            
            

            
            
             

            // System.Console.WriteLine($"This is the date of the user {dateuser}\t{monthuser}\t{yearuser}\t{houruser}\t{minuser}");
            // System.Console.WriteLine($"This the day spend on your life: {totalday}");
        
        
        }

    }
 }



// /*
//             int Year = DateTime.Now.Date.Year;
//             int Month = DateTime.Now.Date.Month;
//             int Day = DateTime.Now.Date.Day;
//             int Hour = DateTime.Now.Hour;
//             int Minute = DateTime.Now.Minute;
//             int Second = DateTime.Now.Second;
//             System.Console.WriteLine($"{Year} Year {Month} Month {Day} Day {Hour} Hours {Minute} Minuite {Second} Seconde");
// */