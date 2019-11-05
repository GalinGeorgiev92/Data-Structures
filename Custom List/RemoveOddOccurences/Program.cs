using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveOddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var result = new List<int>();
            for(int i = 0; i < input.Length; i++)
            {
                var contains = 0;

                for(int j = 0; j < input.Length; j++)
                {
                    if(input[i] == input[j])
                    {
                        contains++;
                    }
                }

                if(contains % 2 == 0)
                {
                    result.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
            
        }
    }
}
