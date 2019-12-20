using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine($"Sum={input.Sum()}; Average={input.Average():f2}");
        }
    }
}
