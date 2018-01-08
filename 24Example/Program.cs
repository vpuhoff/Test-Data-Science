using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _24Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            Console.WriteLine(folder);
            var files = Directory.EnumerateFiles(folder);
            foreach (var file in files)
            {
                var FI = new FileInfo(file);
                var delay = DateTime.Now - FI.CreationTime  ;
                if ( delay.TotalDays >3)
                {
                    Console.WriteLine("{0} Created {1} days ago\t at {2}", FI.Name, delay.TotalDays, FI.CreationTime);
                }
            }
            Console.ReadLine();
        }
    }
}
