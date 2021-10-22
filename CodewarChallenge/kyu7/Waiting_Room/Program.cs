using System;
using System.Collections.Generic;

namespace Waiting_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                There's a waiting room with N chairs set in single row. Chairs are consecutively numbered from 1 to N. 
                First is closest to the entrance (which is exit as well).

                For some reason people choose a chair in the following way

                    Find a place as far from other people as possible
                    Find a place as close to exit as possible

                All chairs must be occupied before the first person will be served

                So it looks like this for 10 chairs and 10 patients
                Chairs 	1 	2 	3 	4 	5 	6 	7 	8 	9 	10
                Patients 	1 	7 	5 	8 	3 	9 	4 	6 	10 	2

                Your task is to find last patient's chair's number. 
            
                using System.Linq;
using System.Collections.Generic;
using System;

public static class Kata
{
    public static int LastChair(int n)
        {
            var occupiedChairs = new SortedList<int, int>();
            occupiedChairs.Add(1, 1);
            occupiedChairs.Add(n, n);
            var numbers = Enumerable.Range(1, n - 2).Select(number => ChooseChair(occupiedChairs, n)).ToList();
            return numbers.Last();
        }

        private static int ChooseChair(SortedList<int, int> occupiedChairs, int n)
        {
            var distances = Enumerable.Range(1, n).Select(number => DistanceToPeople(occupiedChairs, number)).ToList();
            var maxDistance = distances.Max();
            var chairNumber = distances.FindIndex(number => number == maxDistance) + 1;
            occupiedChairs.Add(chairNumber, chairNumber);
            return chairNumber;
        }

        static int DistanceToPeople(SortedList<int, int> occupiedChairs, int chairNumber)
        {
            //var distances = occupiedChairs.Select(number => chairNumber - number);
            //int minPos = distances.Where(number => number >= 0).Min();
            //int maxNeg = distances.Where(number => number <= 0).Max();
            //return minPos - maxNeg + distances.Select(number => Math.Abs(number)).Min();
          if (occupiedChairs.ContainsKey(chairNumber))
            {
                return 0;
            }
            var left = occupiedChairs.First(chair => chair.Key <= chairNumber).Key;
            var right = occupiedChairs.ElementAt(occupiedChairs.IndexOfKey(left) + 1).Key;
            return right - left + Math.Min(left, right);
        }
}
            */
            System.Console.WriteLine("How many chair in the awaiting room? ");
        
            
            List<short> Chair = new List<short>();
            short chairchoose = short.Parse(Console.ReadLine());

            for (short i = 1; i <= chairchoose; i++)
                {Chair.Add(i);}
            
            foreach (var item in Chair)
                {System.Console.WriteLine(item);}


            List<int> Patient = new List<int>(chairchoose);


            
        }

    }
}
