using System;
using System.Collections.Generic;

namespace CumstomArray
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomArray<int> custom = new CustomArray<int>();

            custom.Add(0, 1);
            custom.Add(1, 5);


            for (int i = 0; i < custom.Length; i++)
            {
                Console.WriteLine(custom[i]);
            }

            Console.WriteLine(custom.GetType());

            custom.Add(-1, 5);

            custom.Add(5, 7);

            CustomArray<string> customString = new CustomArray<string>();

            customString.Add(0, "Something");

            Console.WriteLine(customString[0]);
        }
    }
}
