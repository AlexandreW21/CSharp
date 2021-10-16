using System;

namespace Remove_Frist_and_Last_Caracter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine( "pls entre the world you need to Remove First and Last Character {0} : ");
            System.Console.WriteLine(Remove_char(Console.ReadLine()));
        }
        public static string Remove_char(string s)
        {
            
            s = s.Substring(1, s.Length-2);
            return s;
        }   
    }
}
