using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref keyword, değer tiplerin referans tipler gibi kullanılmasını sağlar.

            int number1 = 10;
            int number2 = 20;

            static int Sum(ref int parameter1, int parameter2)
            {
                parameter1 = 1642;
                return parameter1+parameter2;
            }
            Console.WriteLine(Sum(ref number1, number2));
            Console.WriteLine(number1); //it will write 1642.
        }
    }
}

