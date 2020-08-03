using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lesson2
{
    class Task1
    {
        //Написать метод, возвращающий минимальное из трёх чисел.
        //Вашченков Виктор
        static Random r = new Random();
        static int GetMin(int a, int b, int c)
        {
            if (a < b && a < c) return a;
            if (b < c) return b;
            return c;
        }
        static int GetRandom(int max = 10)
        {
            return r.Next(max);
        }
        static void Main(string[] args)
        {
            int a = GetRandom();
            int b = GetRandom();
            int c = GetRandom();

            Console.WriteLine($"a={a} b={b} c={c}");

            Console.WriteLine($"min={GetMin(a,b,c)}");
            Console.ReadKey();
        }
    }
}
