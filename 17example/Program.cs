using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X:");
            var x = double.Parse(Console.ReadLine());
            var resA = Sqrt(x, double.Epsilon);
            var resB = SqrtEtalon(x);
            var delta = Math.Abs(resB - resA);
            Console.WriteLine("Корень = {0}, эталонное значение = {1}, дельта = {2}", resA, resB, delta);
            Console.ReadLine();
        }

        static double Sqrt(double x, double eps)
        {
            double height = 1;
            double width = x;
            do
            {
                height = (height + width) / 2;
                width = x / height;
            } while (Math.Abs(width-height)>eps );
            return height;
        }

        static double SqrtEtalon(double x)
        {
            return Math.Sqrt(x);
        }
    }
}





