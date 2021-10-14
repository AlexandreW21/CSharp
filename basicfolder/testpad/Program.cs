using System;

namespace testpad
{
    class Program
    {
        static void Main(string[] args)
        {
            string frist ="prout".ToUpper();
            string second = "caca";
            RandomNames(  frist,   second);
            System.Console.WriteLine($"{frist}{second}");
        }

        static void RandomNames( string fristName,  string secondName)
        {
            fristName = "alex";
            secondName = "julien";
            Console.WriteLine($"Les noms choisy sont:  {fristName.ToLowerInvariant()} {secondName.ToUpper()}");
        }

    }
}
