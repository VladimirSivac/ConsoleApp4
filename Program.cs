using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        // Task 3
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            double b = Func(a);
            Console.WriteLine("b = {b}");
            Console.ReadLine();
        }
        static double Func(int a)
        {
            double b = 12 * Math.Pow(a, 2) + 7 * a - 6;
            return b;
        }
    }
}
