using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        //enum magic variable durumunun önüne geçer.
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        enum Days2
        {
            Monday = 10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }


        static void Main(string[] args)
        {
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine((int)Days2.Friday);

            var number = 7; //aldığı veriye göre tip tutan değişkenler "var"    
            Console.WriteLine(number);
            number = 'A'; //ASCII 65 -integer-  tutacaktır.
        }
    }
}

