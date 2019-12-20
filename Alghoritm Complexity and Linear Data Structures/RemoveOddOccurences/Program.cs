using System;
using System.Linq;

namespace RemoveOddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var count = 0;

            for(int i = 0; i < input.Count; i++)
            {
                var number = input[i];

                for(int j = 0; j < input.Count; j++)
                {
                    if (input[j] == number)
                    {
                        count++;
                    }
                }

                if(count % 2 == 1)
                {
                    input.RemoveAll(x => x == number);
                    i--;
                }

                count = 0;
            }

            Console.WriteLine($"{string.Join(" ", input)}");
        }
    }
}
