using System;
using System.IO;

namespace CSharp_Lesson4
{
    class Task2
    {
        //Реализуйте задачу 1 в виде статического класса StaticClass;
        //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        //б) *Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
        //в)**Добавьте обработку ситуации отсутствия файла на диске.

            //Задача 1
            //Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
            //Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
            //В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

        //Вашченков Виктор

        static class StaticClass
        {
            public static int FindPairDiv3Count(int[] arr)
            {
                int cnt = 0;

                bool lastDiv3 = false;
                if (arr[0] % 3 == 0) lastDiv3 = true;
                for (int i = 1; i < arr.Length - 1; i++)
                {
                    if (arr[i] % 3 == 0 ^ lastDiv3)
                    {
                        cnt++;
                        lastDiv3 = arr[i] % 3 == 0;
                    }
                }

                return cnt;
            }

            public static int[] readArrayFromFile(string path)
            {
                StreamReader sr = new StreamReader(path);
                string[] strArray = sr.ReadLine().Split(',');
                int[] array = new int[strArray.Length];

                for (int i = 0; i < strArray.Length; i++)
                {
                    array[i] = Convert.ToInt32(strArray[i]);
                }

                sr.Close();
                return array;
            }

            public static void saveArrayToFile(string path, int[] arr)
            {
                StreamWriter sw;
                try
                {
                    sw = new StreamWriter(path);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"Файл {path} не найден на диске! Ошибка: {ex.Message}");
                    return;
                }
                string content = "";

                for (int i = 0; i < arr.Length; i++)
                {
                    content += $"{arr[i]},";
                }

                sw.Write(content.Substring(0, content.Length-1));
                sw.Close();
            }
        }
        static void Main(string[] args)
        {
            int[] a1 = { 6, 2, 9, -3, 6 };
            Console.WriteLine(StaticClass.FindPairDiv3Count(a1));

            int[] a2 = new int[20];
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                a2[i] = r.Next(-10000, 10000);
            }
            Console.WriteLine(StaticClass.FindPairDiv3Count(a2));

            StaticClass.saveArrayToFile("a2.txt", a2);

            int[] a3 = StaticClass.readArrayFromFile("a2.txt");

            if (a2.Length != a3.Length)
            {
                Console.WriteLine("Размеры массивов не совпадают!");
            }
            else
            {
                bool isOk = true;
                for (int i=0; i<a2.Length; i++)
                {
                    if (a2[i] != a3[i])
                    {
                        isOk = false;
                        break;
                    }
                }
                if (isOk) Console.WriteLine("Сохранённый и считанный массив совпадает с исходным.");
                else Console.WriteLine("Содержимое массивов не совпадает!");
            }

            Console.ReadKey();
        }
    }
}
