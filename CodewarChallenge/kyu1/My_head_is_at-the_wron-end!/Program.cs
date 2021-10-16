using System;

namespace My_head_is_at_the_wron_end_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            You're at the zoo... all the meerkats look weird. Something has gone terribly wrong - someone has gone and switched their heads and tails around!

            Save the animals by switching them back. You will be given an array which will have three values (tail, body, head). 
            It is your job to re-arrange the array so that the animal is the right way round (head, body, tail).

            Same goes for all the other arrays/lists that you will get in the tests: you have to change the element positions with the same exact logics

            Simples!

            */
            string[] test = {"5", "1", "3"};
            System.Console.WriteLine("Array befor: ");
            for (var i = 0; i < test.Length ; i++)
            {
                System.Console.WriteLine(test[i]);
            }

            Array.Reverse(test);  // reverse the array 

            System.Console.WriteLine("\nArray After: ");
            for (var i = 0; i < test.Length ; i++)
            {
                System.Console.WriteLine(test[i]);
            }


        }
        // public static string[] FixTheMeerkat(string[] arr)
        //     =>  arr.Reverse().ToArray();
            
    }
}
