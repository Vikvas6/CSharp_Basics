using System;

namespace CSharp_Lesson6
{
    public delegate double Fun(double x, double a);
    class Task1
    {
        //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
        //Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
        //Вашченков Виктор
        public static void Table(Fun F, double x, double b)
        {
            double a = 2;
            Console.WriteLine($"Parameter a = {a}");
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public static double AXSq(double x, double a)
        {
            return a * x * x;
        }

        public static double ASinX(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("f(x) = a*x*x");
            Table(AXSq, -2, 2);
            Console.WriteLine("");
            Console.WriteLine("f(x) = a*sin(x)");
            Table(ASinX, -2, 2);

            Console.ReadKey();
        }
    }
}
