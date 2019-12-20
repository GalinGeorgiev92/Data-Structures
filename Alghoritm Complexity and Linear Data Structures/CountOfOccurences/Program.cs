using System;
using System.Collections.Generic;
using System.Linq;

namespace CountOfOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i]))
                {
                    dict[input[i]] = 0;
                }

                dict[input[i]]++;
            }

            foreach (var kvp in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value} times");
            }
        }
    }
}
