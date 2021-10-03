using System;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a console application that prints the integers from 1 to 100 (inclusive).

            // But:

            // for multiples of three, print Fizz (instead of the number)

            // for multiples of five, print Buzz (instead of the number)

            // for multiples of both three and five, print FizzBuzz (instead of the number)

 
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 ==0 && i % 3 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");  
                    continue; 
                }
                if ((i % 3) == 0 )
                {
                    System.Console.WriteLine("Fizz");
                }
                if ((i % 5) == 0 )
                {
                    System.Console.WriteLine("Buzz");   
                }
                

                else
                {
                    System.Console.WriteLine(i);    
                }
                
            }

        }
    }
}
