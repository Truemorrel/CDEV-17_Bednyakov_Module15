using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_15_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            while (true)
            {
                
                int temp;
                if (!int.TryParse(Console.ReadLine(),out temp))
                {
                    Console.WriteLine("Ошибка. Введите число.");
                    continue;
                };
                Console.Clear();
                ints.Add(temp);
                var AverageInt = ints.Average();
                Console.WriteLine(AverageInt.ToString());
            }
        }
    }
}
