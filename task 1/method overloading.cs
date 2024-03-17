using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        static void Main(string[] args)
        {

            //method overloading
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 6));

        }
    }
}

