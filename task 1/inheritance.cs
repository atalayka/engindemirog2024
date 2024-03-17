using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        //inheritance.

        class Person
        {
            public int Id { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
        }

        class Customer : Person
        {
            public string? BirthCity { get; set; }
        }
        class Student : Person
        {
            public string? Department { get; set; }
        }
        static void Main(string[] args)
        {
            Person[] people = new Person[3]{
                new Customer{
                    Id = 1,
                    FirstName = "John",
                    LastName = "Smith",
                    BirthCity = "London"
                },
                new Student{
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Department = "Computer Science"
                },
                new Person{
                    Id = 3,
                    FirstName = "Michael",
                    LastName = "Jackson"
                },
            };
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Id} {person.FirstName} {person.LastName}");
            }
        }
    }
}

