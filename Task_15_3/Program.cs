using System;
using System.Collections.Generic;
using System.Linq;
using Task_15_3.Model;

namespace Task_15_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
               new Car("Suzuki", "JP"),
               new Car("Toyota", "JP"),
               new Car("Opel", "DE"),
               new Car("Kamaz", "RUS"),
               new Car("Lada", "RUS"),
               new Car("Honda", "JP"),
            };

            var carsByCountry2 = cars
               .GroupBy(car => car.CountryCode)
               .Select(g => new
               {
                   Name = g.Key,
                   Count = g.Count(),
                   Cars = g.Select(c => c)
               });

            // Выведем результат
            foreach (var group in carsByCountry2)
            {
                // Название группы и количество элементов
                Console.WriteLine($"{group.Name} : {group.Count} авто");

                foreach (Car car in group.Cars)
                    Console.WriteLine(car.Manufacturer);

                Console.WriteLine();
            }
        }
    }
}
