using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        // Task 2
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int c = Sum(a, b);
            Console.WriteLine($"a + b = {c}");
            Console.ReadLine();
        }
        static int Sum(int a, int b)
        { 
            return a + b; 
        }

    }
}
