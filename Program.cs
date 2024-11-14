using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        // Task 6
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("x3 = ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            double y3 = double.Parse(Console.ReadLine());

            double a = F(x1, y1, x2, y2);
            double b = F(x2, y2, x3, y3);
            double c = F(x1, y1, x3, y3);
            double per = D(a, b, c);

            Console.WriteLine($"Длина отрезка a: {a}");
            Console.WriteLine($"Длина отрезка b: {b}");
            Console.WriteLine($"Длина отрезка c: {c}");
            Console.WriteLine($"Периметр треугольника: {per}");
            Console.WriteLine($"Площадь треугольника: {Square(per, a, b, c)}");
            Console.ReadLine();
        }
        static double F(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static double D(double a, double b, double c)
        {
            return a + b + c;
        }
        static double Square(double per, double a, double b, double c)
        {
            double halfper = per / 2;
            double razna = halfper - a;
            double raznb = halfper - b;
            double raznc = halfper - c;
            return Math.Sqrt(halfper * razna * raznb * raznc);
        }
    }
}
