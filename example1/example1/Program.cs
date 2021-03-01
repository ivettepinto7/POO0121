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
            Console.WriteLine("The result is : "+ sum(a,b));
        }
        public static int sum(int a, int b){
            int suma = a + b;
            return suma;
        }
    }
}