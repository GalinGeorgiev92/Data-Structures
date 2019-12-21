using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CalculateSequenceWithAQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            Queue queue = new Queue();
            queue.Enqueue(input);
            int index = 0;
            int[] members = new int[50];

            while(true)
            {
                int element = (int)queue.Dequeue();

                members[index++] = element;

                if(index == 50)
                {
                    break;
                }

                queue.Enqueue(element + 1);
                queue.Enqueue(2 * element + 1);
                queue.Enqueue(element + 2);
            }

            while(queue.Count > 0)
            {
                Console.Write($"{queue.Dequeue()}, ");
            }
        }
    }
}
