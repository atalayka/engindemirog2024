using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        //interfaces demo.

        public interface IWorker
        {
            public void Work();
        }
        public interface IEat
        {
            public void Eat();
        }
        public interface ISalary
        {
            public void GetSalary();
        }
        class Manager : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("Manager eats.");
            }

            public void GetSalary()
            {
                Console.WriteLine("Manager gets salary.");
            }

            public void Work()
            {
                Console.WriteLine("Manager works.");
            }
        }
        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("Worker eats.");
            }

            public void GetSalary()
            {
                Console.WriteLine("Worker gets salary.");
            }

            public void Work()
            {
                Console.WriteLine("Worker works.");
            }
        }
        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Robot works.");
            }
        }
        static void Main(string[] args)
        {
            IWorker[] workers =
            [
                new Manager(),
                new Robot(),
                new Worker(),
            ];
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] ieat = [
                new Manager(),
                new Worker(),
            ];
            foreach (var eater in ieat)
            {
                eater.Eat();
            }

        }
    }
}

