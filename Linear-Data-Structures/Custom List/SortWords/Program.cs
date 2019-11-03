using System;
using System.Linq;

namespace SortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var result = input.OrderBy(x => x);

            Console.WriteLine($"{string.Join(" ", result)}");


        }
    }
}
