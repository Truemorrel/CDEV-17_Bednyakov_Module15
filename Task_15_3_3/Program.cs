using System;
using System.Linq;
using System.Collections.Generic;
using Task_15_3_3.Model;

namespace Task_15_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

            var fakePhones = phoneBook.GroupBy(e => (e.Email.Contains("example")) ? "fake" : "real")
                .Select(p => new
                {
                    Name = p.Key,
                    Contacts = p.Select(c => c)
                });
            foreach (var fakeContact in fakePhones)
            {
                Console.WriteLine($"{fakeContact.Name}: ");
                foreach (var contact in fakeContact.Contacts)
                {
                    Console.WriteLine($"{contact.Name}, {contact.PhoneNumber}, {contact.Email}");
                }
                Console.WriteLine();
            };
        }
    }
}
