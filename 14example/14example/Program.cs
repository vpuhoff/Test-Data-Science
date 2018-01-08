using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите S:");
            int s = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int x = 0; x < n; x++)
            {
                A[x] = x+1;
            }
            int i,j,ai,aj=0; //инициализация массива А и переменных i,j
      
            if (n>=s) // Чисел достаточно, чтобы сразу найти одно решение
            {
                i = 0;
                j = s -2;
                ai = A[i];
                aj = A[j];
                if (i==j)
                {
                    Console.WriteLine("Решения не существует");
                }
                Console.WriteLine("i={0}\tj={1}\t{2}+{3}={4}",i,j,ai,aj,s);
                Assert(ai + aj, s);//Сравним с эталоном и либо сообщим что корректно, либо сообщим об ошибке
            }
            else
            {
                if (s-n>=n)
                {
                    //Это значит, что второе слагаемое либо больше либо равно n, что по условию задачи не допустимо
                    Console.WriteLine("Решение не существует");
                }
                else
                {
                    j = n-1;
                    i = s - n-1;
                    ai = A[i];
                    aj = A[j];
                    Console.WriteLine("i={0}\tj={1}\t{2}+{3}={4}", i, j, ai, aj, s);
                    Assert(ai + aj, s);//Сравним с эталоном и либо сообщим что корректно, либо сообщим об ошибке
                }
            }
            Console.ReadLine();
        }

        private static void Assert(int v, int s)
        {
            if (v==s)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Верно: {0}={1}", v, s);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошмбка: {0}!={1}", v, s);
            }
        }
    }
}
