using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
        }
        public static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Select your option");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine();
        }
    }

}
