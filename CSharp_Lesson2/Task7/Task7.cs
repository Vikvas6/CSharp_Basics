using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Task7
    {
        //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        //Вашченков Виктор
        static int ReadNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void ShowNumbers(int cur, int max)
        {
            Console.WriteLine(cur);
            if (cur < max) ShowNumbers(cur + 1, max);
        }
        static int RecurseSum(int cur, int max)
        {
            if (cur == max) return cur;
            return cur + RecurseSum(cur + 1, max);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два целых числа");
            int a = ReadNumber();
            int b = ReadNumber();

            Console.WriteLine("Вывод чисел");
            ShowNumbers(a, b);

            Console.WriteLine($"Сумма чисел равна {RecurseSum(a,b)}");

            Console.ReadKey();
        }
    }
}
