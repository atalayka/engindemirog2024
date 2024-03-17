using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        class Button
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public string? Text { get; set; }
            public void Add()
            {
                Console.Write("#");
            }
        }
        static void Main(string[] args)
        {
            Button button = new Button();
            button.Width = 50;
            button.Height = 50;
            button.Text = "My Button";

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    button.Add();
                    Console.Write(" ");
                }
                Console.WriteLine("");

            }


        }
    }
}

