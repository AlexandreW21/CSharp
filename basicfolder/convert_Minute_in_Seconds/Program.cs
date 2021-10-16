using System;

namespace convert_Minute_in_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a function that takes an integer minutes and converts it to seconds.
            System.Console.WriteLine("Howmany minut to you want a convert? \n");
            int inputUser = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(MinInSec(inputUser));

        }
        
        static int MinInSec(int WholeNum)
        {

            int TotalInSec =  WholeNum * 60 ;
            return TotalInSec;

        }
    }
}