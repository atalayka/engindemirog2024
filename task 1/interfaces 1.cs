using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        //interfaces.

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        }
        class Student : IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
        class Worker : IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Profession { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

        class PersonManager //business layer.
        {
            public void Add(IPerson person) //this method, adds person. uses person interface.
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }
        static void Main(string[] args)
        {
            PersonManager manager = new();

            manager.Add(new Customer { Id = 1, Address = "123 Main Street", FirstName = "John", LastName = "Doe" }); // person manager class, add method It takes an object derived from the Iperson interface as an argument.
            manager.Add(new Student { Id = 2, FirstName = "Jane", LastName = "Doe", Department = "Computer Science" });
            manager.Add(new Worker { Id = 3, FirstName = "Bob", LastName = "Smith", Department = "Engineering", Profession = "Software Engineer" });
        }
    }
}

