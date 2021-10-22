using System;
using System.Collections.Generic;

namespace Find_The_Odd_int
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Given an array of integers, find the one that appears an odd number of times.
                There will always be only one integer that appears an odd number of times.
                
                Examples:
                [7] should return 7, because it occurs 1 time (which is odd).
                [0] should return 0, because it occurs 1 time (which is odd).
                [1,1,2] should return 2, because it occurs 1 time (which is odd).

            */
            int[] arraytest = {1, 1, 1, 1, 2, 3, 1, 1, 3};
            
            Array.Sort(arraytest);
            
            for (var i = 0; i < arraytest.Length ; i++) // loop to the array 
            {
                int toto = 0;
                
                for (var t = 0; t < arraytest.Length; t++)
                {
                    if (arraytest[i] == arraytest[t]){toto++;}
                }

                if (toto % 2 != 0){System.Console.WriteLine(arraytest[i]);}  
            }
        }   
    }
}
