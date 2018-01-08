using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Example
{
    class Program
    {
        static int[] Merge_Sort(int[] array)
        {
            if (array.Length == 1)
                return array;
            int mid_point = array.Length / 2;
            return Merge(Merge_Sort(array.Take(mid_point).ToArray()), Merge_Sort(array.Skip(mid_point).ToArray()));
        }

        static int[] Merge(int[] masA, int[] masB)
        {
            int a = 0, b = 0;
            int[] merged = new int[masA.Length + masB.Length];
            for (int i = 0; i < masA.Length + masB.Length; i++)
            {
                if (b < masB.Length && a < masA.Length)
                    if (masA[a] > masB[b])
                        merged[i] = masB[b++];
                    else
                        merged[i] = masA[a++];
                else
                    if (b < masB.Length)
                    merged[i] = masB[b++];
                else
                    merged[i] = masA[a++];
            }
            return merged;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[100];
            //заполняем массив случайными числами
            Random rd = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rd.Next(1, 101);
            }
            Console.WriteLine("Массив до сортировки:");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            //сортировка

            arr = Merge_Sort(arr);

            Console.WriteLine("Массив после сортировки:");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
        }
    }
}
