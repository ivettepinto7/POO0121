using System;

namespace example1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            
            Console.WriteLine("Enter a value:");
            a = Int32.Parse(Console.ReadLine() );
            
            Console.WriteLine("Enter another value:");
            b = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine($"Adding the values of {a} and {b} give: "+ sum(a,b));

            String x = sum(a, b) % 2 == 0 ? "Even number" : "Odd number";

            Console.WriteLine(x);
 
        }
        public static int sum(int a, int b){
            return a + b;
        }
    }
}