using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_15_5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bitsA = new string[] { "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7"};

            var bitsB = new string[] { "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7" };

            var bitsC = bitsA.Select(c => c.Replace("A", "C"));

            int i = 0;
            var oddBits = bitsA.
                Select(c => new 
                {
                    j = i++ % 2,
                    c
                }).
                Where(c => (c.j == 1));
            foreach (var bit in oddBits)
            {
                Console.WriteLine(bit);
            }
        }
    }
}
