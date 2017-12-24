using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog
{
    class Program
    {
        static Dictionary<string, int> Memory = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите имя:");
                string name = Console.ReadLine();
                if (!Memory.ContainsKey(name))
                {
                    Memory.Add(name, 1);
                    Console.WriteLine("Я впервые встретил данное имя.");
                }
                else
                {
                    Memory[name]++;
                    Console.WriteLine("Я встречал данное имя {0} раз.", Memory[name]);
                }
            } while (true);
        }
    }
}
