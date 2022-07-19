using System;
using System.Collections.Generic;

namespace Task_15_3_3.Model
{
    public class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact( string name, long phoneNumber, string email) // метод-конструктор
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}