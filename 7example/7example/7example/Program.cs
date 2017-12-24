using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7example
{
    class Человек
    {
        public int Вес;
        public int Рост;
        public string Пол;
        public int Возраст;
        public virtual void СделатьЧтото()
        {
            Console.WriteLine("Мне лень!");
        }
    }
    class Мужчина : Человек
    {
        new string Пол = "МУЖ";
        public override void СделатьЧтото()
        {
            Console.WriteLine(Пол+":Забил гвоздь!"); 
        }
    }
    class Женщина : Человек
    {
        new string Пол = "ЖЕН";
        public override void СделатьЧтото()
        {
            Console.WriteLine(Пол+":Полила цветы!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Вася = new Мужчина();
            var Маша = new Женщина();
            var Чел  = new Человек();
            Вася.СделатьЧтото();
            Маша.СделатьЧтото();
            Чел.СделатьЧтото();
            Console.ReadLine();
            //МУЖ: Забил гвоздь!
            //ЖЕН:Полила цветы!
            //Мне лень!
        }
    }
}
