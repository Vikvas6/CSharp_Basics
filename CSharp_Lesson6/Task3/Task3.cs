using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Task3
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        // Создаем конструктор
        public Student(string lastName, string firstName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }

    class Task3
    {
        //Переделать программу Пример использования коллекций для решения следующих задач:
        //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
        //в) отсортировать список по возрасту студента;
        //г) *отсортировать список по курсу и возрасту студента;
        //Вашченков Виктор
        static int MyDelegat(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {
                                
            return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
        }
        static bool FindCouse5(Student st)
        {
            return st.course == 5;
        }
        static bool FindCourse6(Student st)
        {
            return st.course == 6;
        }
        static bool FindAge1820(Student st)
        {
            return st.age >= 18 && st.age <= 20;
        }
        static Dictionary<int, int> CalculateCouseFreq(List<Student> sts)
        {
            Dictionary<int, int> res = new Dictionary<int, int>();
            foreach (Student st in sts)
            {
                if (res.ContainsKey(st.course)) res[st.course]++;
                else res[st.course] = 1;
            }
            return res;
        }
        static string PrintDictFreq(Dictionary<int, int> dict)
        {
            StringBuilder res = new StringBuilder();
            foreach(int key in dict.Keys)
            {
                res.Append($" [курс {key}: {dict[key]}]");
            }
            return res.ToString();
        }
        static int CompareByAge(Student st1, Student st2)
        {
            return st1.age < st2.age ? -1 : 1;
        }
        static int CompareByCourseAndAge(Student st1, Student st2)
        {
            if (st1.course == st2.course) return CompareByAge(st1, st2);
            else return st1.course < st2.course ? -1 : 1;
        }
        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            List<Student> list = new List<Student>();                             // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(' ');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[5]) < 5) bakalavr++; else magistr++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            list.Sort(new Comparison<Student>(MyDelegat));
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            foreach (var v in list) Console.WriteLine(v.firstName);

            Console.WriteLine();
            Console.WriteLine("Домашнее задание");
            Console.WriteLine("Всего студентов на 5м курсе:" + list.FindAll(FindCouse5).Count);
            Console.WriteLine("Всего студентов на 6м курсе:" + list.FindAll(FindCourse6).Count);
            Console.WriteLine();

            Console.WriteLine("Всего студентов от 18 до 20 лет:" + list.FindAll(FindAge1820).Count);
            Console.WriteLine("Курсы от 18 до 20 лет:" + PrintDictFreq(CalculateCouseFreq(list.FindAll(FindAge1820))));
            Console.WriteLine();

            Console.WriteLine("Список студентов, отсортированный по возрасту");
            list.Sort(CompareByAge);
            foreach (var v in list) Console.WriteLine($"{v.lastName} {v.firstName} {v.age}");
            Console.WriteLine();

            Console.WriteLine("Список студентов, отсортированный по курсу и возрасту");
            list.Sort(CompareByCourseAndAge);
            foreach (var v in list) Console.WriteLine($"{v.lastName} {v.firstName} {v.course} {v.age}");
            Console.WriteLine();

            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();

        }
    }
}
