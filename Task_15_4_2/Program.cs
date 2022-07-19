using System;
using System.Collections.Generic;
using System.Linq;
using Task_15_4_2.Model;

namespace Task_15_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
               new Department() {Id = 1, Name = "Программирование"},
               new Department() {Id = 2, Name = "Продажи"}
            };

            var employees = new List<Employee>()
            {
               new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
               new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
               new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
               new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var staffing = departments.GroupJoin(employees,
                dep => dep.Id, 
                p => p.DepartmentId,
                ( dep, p) => new
                {
                    DepName = dep.Name,
                    empNames = p.Select(n => n)
                });
            //var staffing = from emp in employees
            //               join dep in departments on emp.DepartmentId equals dep.Id
            //               select new
            //               {
            //                   emp.Name,
            //                   DepName = dep.Name
            //               };
            foreach (var unit in staffing)
            {
                Console.WriteLine($"{unit.DepName} :");
                foreach (var employee in unit.empNames)
                {
                    Console.WriteLine($"{employee.Name} : {employee.Id}"); 
                }
                Console.WriteLine();
            }
        }
    }
}
