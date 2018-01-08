using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Code
{
    class Program
    {
        public static bool isPalRecu(string s)
        {
            if (s.Length == 0 || s.Length == 1)//больше нет символов либо остался лишь один символ в центре строки
                return true;
            if (s[0] == s[s.Length - 1])//сравниваем первый символ с последним
                return isPalRecu(s.Substring(1, s.Length - 2));//отправляем на проверку содержимое строки между первым и последним символом                
            return false;
        }
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            if (isPalRecu(s))
            {
                Console.WriteLine("Это полиндром!");
            }
            else
            {
                Console.WriteLine("Это не полиндром!");
            }
        }
    }
}
