using System;

namespace AccessModifierDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Access Modifier Demo");

            Console.WriteLine("**********************");

            int length = 10;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
