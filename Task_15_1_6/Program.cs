using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_15_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] spacers = new char[] { ' ', ',', '.', ';', ':', '?', '!', '\''};
            var inputString = Console.ReadLine();
            if (string.IsNullOrEmpty(inputString))
            {
                Console.WriteLine("Введите непустую строку");
            }
            IEnumerable<char> result = inputString.ToCharArray().Except(spacers);
            result = result.Union(result);
            Console.WriteLine(result.ToArray()); ;
        }
    }
}
