using System;
using System.Collections.Generic;

namespace Task3
{
    class Task3
    {
        //а) Дописать класс для работы с одномерным массивом.
        //Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        //Создать свойство Sum, которое возвращает сумму элементов массива,
        //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
        //метод Multi, умножающий каждый элемент массива на определённое число,
        //свойство MaxCount, возвращающее количество максимальных элементов. 
        //б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
        //е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
        //Вашченков Виктор
        

        static void Main(string[] args)
        {
            CoolArray a1 = new CoolArray(10, 0, 2);
            a1.Print();

            Console.WriteLine($"Sum: {a1.Sum}");

            Console.Write($"Inverse: ");
            a1.Inverse().Print();

            Console.Write($"Multi -2: ");
            a1.Multi(-2).Print();

            Console.WriteLine($"MaxCount: {a1.MaxCount()}");

            CoolArray a2 = new CoolArray(new int[] { 1, 2, 2, 3, 3, 3, 3 });
            Console.Write("New array: ");
            a2.Print();

            Console.WriteLine($"MaxCount: {a2.MaxCount()}");

            Dictionary<int, int> freq = a2.getFrequency();
            string strFreq = "{";
            foreach(int idx in freq.Keys)
            {
                strFreq += $" {idx}: {freq[idx]},";
            }
            strFreq = strFreq.Substring(0, strFreq.Length - 1) + " }";
            Console.WriteLine($"Freq dict: {strFreq}");

            Console.ReadKey();
        }
    }
}
