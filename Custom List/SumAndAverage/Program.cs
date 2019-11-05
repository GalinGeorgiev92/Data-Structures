using System;
using System.Linq;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var sum = input.Sum();
            var average = input.Average();

            Console.Write($"Sum={sum}; ");
            Console.WriteLine($"Average={average:f2}");
        }
    }
}
