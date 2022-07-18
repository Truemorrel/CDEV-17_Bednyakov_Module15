using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_15_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "каша";
            string word2 = "малаша";
            Console.WriteLine(word1);
            Console.WriteLine(word2);
            Console.WriteLine();
            var microBuses = word1.CoupledChars(word2);
            foreach (char ch in microBuses)
            {
                Console.WriteLine(ch);
            };
        }
    }
}
