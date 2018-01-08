using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22example
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение N:");
            var n = int.Parse(Console.ReadLine());
            var maxb = Math.Floor(Math.Sqrt(n));
            bool finded = false;
            if (maxb >0 )
            {
                for (double  b = 1.0; b <= maxb ; b=b+1)
                {
                    double a = Math.Sqrt(n - b * b);
                    if (a%1==0)//Число является целым
                    {
                        var s = a * a + b * b;
                        if (s==n) //Проверка
                        {
                            Console.WriteLine("a={0}\tb={1}\ta^2+b^2={2}+{3}={4}",a,b,a*a,b*b,s);
                            finded = true;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка в алгоритме!");
                        }
                    }
                }
                if (!finded )
                {
                    Console.WriteLine("Решения нет.");
                }
            }
            else
            {
                Console.WriteLine("Решения нет.");
            }
        }

        
    }
}
