using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        class Customer
        {
            //field.
            private string? _firstName;
            public string? FirstName
            {
                get
                {
                    return "Mr. " + _firstName;
                }
                set
                {
                    _firstName = value;
                }
            }
            //properties
            public int Id { get; set; }
            public string? LastName { get; set; }
            public string? City { get; set; }
        }
        static void Main(string[] args)
        {
            //classes can hold properties and methods.

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.FirstName = "Ahmet";
            customer.LastName = "Yılmaz";

            Customer customer1 = new Customer
            {
                City = "Ana kara",
                FirstName = "Selami",
                LastName = "Garbuk",
            };

            Console.WriteLine(customer1.FirstName);
            //Encapsulation friendly.
        }
    }
}

