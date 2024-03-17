using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static int Multiply(int[] numbers)
        {
            int result = 1;
            foreach (var item in numbers)
            {
                result *= item;
            }
            return result;
        }
        static void Main(string[] args)
        {
            //params keyword, variable number of arguments
            int[] nums = [1,2,3,4,5];
            Console.WriteLine(Multiply(nums));

        }
    }
}

