using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"a + b = {Sum(a, b)}");
            Console.WriteLine($"a - b = {Razn(a, b)}");
            Console.WriteLine($"a * b = {Proizv(a, b)}");
            Console.WriteLine($"a / b = {Del(a, b)}");
            Console.ReadLine();
        }
        static double Sum(double a, double b)
        { 
            return a + b; 
        }
        static double Razn(double a, double b)
        {
            return a - b;
        }
        static double Proizv(double a, double b)
        {
            return a * b;
        }
        static double Del(double a, double b)
        {
            return a / b;
        }
    }
}
