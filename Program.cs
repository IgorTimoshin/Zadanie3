using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Представлена программа перевода действительных чисел ");
            Console.WriteLine("в различные системы счисления. ");
            Console.WriteLine("Чтобы выбрать необходимую систему счисления");
            Console.WriteLine("введите, соответсвенно числа 2, 8, 16");

            Console.WriteLine("Введите переводимое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите необходимую систему счисления: ");
            int y = int.Parse(Console.ReadLine());

            switch(y)
            {
                case 2:
                    string q = Convert.ToString(x, 2);
                    Console.WriteLine("Результат перевода: {0} ", q);
                    break;
                case 8:
                    string w = Convert.ToString(x, 8);
                    Console.WriteLine("Результат перевода: {0}", w);
                    break;
                case 16:
                    string e = Convert.ToString(x, 16);
                    Console.WriteLine("Результат перевода: {0}", e);
                    break;
            }
            Console.WriteLine("Для выхода, нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}