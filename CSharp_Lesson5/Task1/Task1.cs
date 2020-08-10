using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Task1
    {
        //Создать программу, которая будет проверять корректность ввода логина.
        //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        //а) без использования регулярных выражений;
        //б) **с использованием регулярных выражений.
        //Вашченков Виктор
        private static bool CheckLoginRegEx(string login)
        {
            string pattern = @"^[a-zA-Z]\w{1,9}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(login);
        }
        private static bool CheckLogin(string login)
        {
            if (login.Length < 2 || login.Length > 10) return false;
            if (!Char.IsLetter(login[0])) return false;
            foreach(char ch in login)
            {
                if (!Char.IsLetterOrDigit(ch)) return false;
            }
            return true;
        }
        private static void CheckLogin2WaysAndConsoleWrite(string login)
        {
            Console.WriteLine($"Проверка логина {login}:");

            if (CheckLogin(login)) Console.WriteLine("ОК");
            else Console.WriteLine("Введён некоректный логин");

            if (CheckLoginRegEx(login)) Console.WriteLine("RegEx: ОК");
            else Console.WriteLine("RegEx: Введён некоректный логин");

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string[] logins = {"login", "lo1ing", "1goign", "s123456789", "s1234567890"};

            foreach(var login in logins)
            {
                CheckLogin2WaysAndConsoleWrite(login);
            }
            Console.WriteLine("Введите логин");
            var user_login = Console.ReadLine();

            CheckLogin2WaysAndConsoleWrite(user_login);

            Console.ReadKey();
        }
    }
}
