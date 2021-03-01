using System;

namespace example1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("Enter a value:");
            a = Int32.Parse(Console.ReadLine() );
            Console.WriteLine("Enter another value:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Adding the values of {a} and {b} give: "+ sum(a,b));
            if (sum(a, b) % 2 == 0)
                Console.WriteLine($"Adding {a} and {b} gives a even number");
            else
                Console.WriteLine($"Adding {a} and {b} gives a odd number");

        }
        public static int sum(int a, int b){
            int suma = a + b;
            return suma;
        }
    }
}