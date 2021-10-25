using System;
using System.Collections.Generic; 

namespace Reversed_sequence
{
    /*Build a function that returns an array of integers from n to 1 where n>0.

        Example : n=5 --> [5,4,3,2,1]
    */
    class Program
    {
        static void Main(string[] args)
        {
            
            foreach (var item in ReverseSeq(5))
            {
                System.Console.WriteLine(item);
            }
        }
        public static int[] ReverseSeq(int n)
        {
            int[] NArr = new int[n];
            
            for (int i = 0; i < n ; i++)
                {
                    NArr[i] = NArr.Length - i;
                        
                }
            return NArr;
        }
        

    }
}
