using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	/*Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.*/
	class BMI
	{
		static double calculateBMI(double weight, double height)
		{
			return weight / (height * height);
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Введите Ваш рост");
			var height = Console.ReadLine();

			Console.WriteLine("Введите Ваш вес");
			var weight = Console.ReadLine();

			Console.WriteLine($"Ваш ИМТ {calculateBMI(Convert.ToDouble(weight), Convert.ToDouble(height))}");

			Console.ReadKey();
		}
	}
}
