using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubsequence
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var longest = 0;
            List<int> result = new List<int>();
            result.Add(input[0]);

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    longest++;

                    if (longest >= result.Count)
                    {
                        result.Clear();

                        for (int j = 0; j <= longest; j++)
                        {
                            result.Add(input[i]);
                        }
                    }
                }
                else
                {
                    longest = 0;
                }
            }


            Console.WriteLine(string.Join(" ", result));
        }
    }
}