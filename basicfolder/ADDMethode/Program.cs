using System;

namespace basic1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(" Hi, pls entre 2 number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
                
                
                // \r\n and \r \n are basicaly the same  \r is more for windows style  \n for linux base                 
            System.Console.WriteLine("\r\nThe total of the addiction of this 2 numbre are" + Environment.NewLine + summarisation(n1, n2));
            
        }

        private static int summarisation(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }
    }
}
