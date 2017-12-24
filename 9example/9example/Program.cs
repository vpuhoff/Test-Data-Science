using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9example
{
    class Program
    {
        static int GlobalVar = 1;
        static void Main(string[] args)
        {
            Func1();
            Func2();
            Console.ReadLine();
        }
        static void Func1()
        {
            GlobalVar++;
            Console.WriteLine(GlobalVar);
        }
        static void Func2()
        {
            GlobalVar= GlobalVar*2;
            Console.WriteLine(GlobalVar);
        }
    }
}
