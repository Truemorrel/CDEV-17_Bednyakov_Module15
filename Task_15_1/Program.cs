using System;
using System.Linq;

namespace Task_15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Список напитков в продаже
            string[] drinks = { "Вода", "Кока-кола", "Лимонад", "Вино" };
            // Алкогольные напитки
            string[] alcohol = { "Вино", "Пиво", "Сидр" };

            // Убираем алкоголь из ассортимента
            var drinksForKids = drinks.Except(alcohol);
            
            Console.WriteLine("Except()");
            Console.WriteLine();

            foreach (string drink in drinksForKids)
                Console.WriteLine(drink);
            Console.ReadLine();
            Console.WriteLine("Intersect()");
            Console.WriteLine();
            string[] cars = { "Волга", "Москвич", "Нива", "Газель" };
            string[] buses = { "Газель", "Икарус", "ЛиАЗ", "Газель" };

            // поищем машины, которые можно считать микроавтобусами
            var microBuses = cars.Intersect(buses);

            foreach (string mb in microBuses)
                Console.WriteLine(mb);

            Console.ReadLine();
            Console.WriteLine("Union()");
            Console.WriteLine();
            var vehicles = cars.Union(buses);

            foreach (string v in vehicles)
                Console.WriteLine(v);

            Console.ReadLine();
            Console.WriteLine("Concat()");
            Console.WriteLine();
            var machines = cars.Concat(buses);

            foreach (string v in machines)
                Console.WriteLine(v);

            Console.ReadLine();
            Console.WriteLine("Distinct()");
            Console.WriteLine();

            var uniqVehicles = machines.Distinct();

            foreach (string v in uniqVehicles)
                Console.WriteLine(v);
        }
    }
}
