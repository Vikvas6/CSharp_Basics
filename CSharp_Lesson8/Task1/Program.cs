using System;
using System.Reflection;

namespace Task1
{
    class Program
    {
        //С помощью рефлексии выведите все свойства структуры DateTime
        //Вашченков Виктор
        static void Main(string[] args)
        {
            Type dateTimeType = typeof(DateTime);

            PropertyInfo[] properties = dateTimeType.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }

            Console.ReadKey();
        }
    }
}
