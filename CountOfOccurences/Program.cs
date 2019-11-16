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

            var result = new Dictionary<int, int>();

            for(int i =0;i < input.Length; i++)
            {
                if(!result.ContainsKey(input[i]))
                {
                    result[input[i]] = 0;
                }

                result[input[i]]++;
            }

            foreach (var kvp in result.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value} times");
            }
        }
    }
}
