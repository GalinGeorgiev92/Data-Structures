using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbersWithAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack(input);

            while(stack.Count != 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
