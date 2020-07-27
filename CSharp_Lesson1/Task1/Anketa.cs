using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson1
{
	/*Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
		а) используя  склеивание;
		б) используя форматированный вывод;
		в) используя вывод со знаком $.*/
	class Anketa
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите Ваше имя");
			var name = Console.ReadLine();

			Console.WriteLine("Введите Вашу фамилию");
			var surname = Console.ReadLine();

			Console.WriteLine("Введите Ваш возраст");
			var age = Console.ReadLine();

			Console.WriteLine("Введите Ваш рост");
			var height = Console.ReadLine();

			Console.WriteLine("Введите Ваш вес");
			var weight = Console.ReadLine();

			Console.WriteLine("Имя: " + surname + " " + name + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);
			Console.WriteLine("Имя: {0} {1} Возраст: {2} Рост: {3} Вес: {4}", surname, name, age, height, weight);
			Console.WriteLine($"Имя: {surname} {name} Возраст: {age} Рост: {height} Вес: {weight}");

			Console.ReadKey();
		}
	}
}
