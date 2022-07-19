using System;
using System.Collections.Generic;
using System.Linq;
using Task_15_4_1.Model;

namespace Task_15_4_1
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

            //var staffing = employees.Join(departments,
            //    p => p.DepartmentId,
            //    dep => dep.Id,
            //    (p, dep) => new
            //    {
            //        Name = p.Name,
            //        DepName = dep.Name,
            //    });
            var staffing = from emp in employees
                           join dep in departments on emp.DepartmentId equals dep.Id
                           select new
                           {
                               Name = emp.Name,
                               DepName = dep.Name
                           };
            foreach (var employee in staffing)
            {
                Console.WriteLine($"{employee.Name} : {employee.DepName}");
            }
        }
    }
}
