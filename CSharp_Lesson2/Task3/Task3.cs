using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Task3
    {
        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        //Вашченков Виктор
        static int ReadNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Вводите целые числа, программа остановится, когда будет введён ноль");
            while (true)
            {
                int input = ReadNumber();
                if (input == 0) break;
                if (input % 2 == 1 && input > 0) sum += input;
            }

            Console.WriteLine($"Сумма всех нечетных положительных чисел равна {sum}");
            Console.ReadKey();
        }
    }
}
