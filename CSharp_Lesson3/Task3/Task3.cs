using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Task3
    {
        //*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
        //Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
        //* Добавить свойства типа int для доступа к числителю и знаменателю;
        //* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
        //** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
        //*** Добавить упрощение дробей.
        //Вашченков Виктор

        class Decimal
        {
            private int numerator;
            private int denominator;

            public Decimal(int numerator, int denominator)
            {
                this.Numerator = numerator;
                this.Denominator = denominator;
            }

            public int Numerator { get => numerator; set => numerator = value; }
            public int Denominator {
                get => denominator;
                set { 
                    if (value == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
                    if (value < 0)
                    {
                        denominator = -value;
                        numerator = -numerator;
                    } else
                    {
                        denominator = value;
                    }
                } 
            }

            public double DecimalValue { get => (double)numerator / denominator; }

            public Decimal Simplification()
            {
                int greatestFactor = GreatestFactor(numerator, denominator);
                if (greatestFactor > 1)
                {
                    return new Decimal(numerator / greatestFactor, denominator / greatestFactor);
                }
                else
                {
                    return new Decimal(numerator, denominator);
                }
            }

            private static int GreatestFactor(int a, int b)
            {
                while (a != b)
                {
                    if (a > b) a = a - b;
                    else b = b - a;
                }
                return a;
            }

            public static Decimal operator +(Decimal d1, Decimal d2)
            {
                if (d1.denominator == d2.denominator) return new Decimal(d1.numerator + d2.numerator, d1.denominator);
                else
                {
                    int greatestFactor = GreatestFactor(d1.denominator, d2.denominator);
                    return new Decimal(d1.numerator * d2.denominator / greatestFactor + d2.numerator * d1.denominator / greatestFactor, d1.denominator * d2.denominator / greatestFactor);
                }
            }
            public static Decimal operator -(Decimal d1, Decimal d2)
            {
                if (d1.denominator == d2.denominator) return new Decimal(d1.numerator - d2.numerator, d1.denominator);
                else
                {
                    int greatestFactor = GreatestFactor(d1.denominator, d2.denominator);
                    return new Decimal(d1.numerator * d2.denominator / greatestFactor - d2.numerator * d1.denominator / greatestFactor, d1.denominator * d2.denominator / greatestFactor);
                }
            }
            public static Decimal operator *(Decimal d1, Decimal d2)
            {
                return new Decimal(d1.numerator * d2.numerator, d1.denominator * d2.denominator);
            }
            public static Decimal operator /(Decimal d1, Decimal d2)
            {
                return new Decimal(d1.numerator * d2.denominator, d1.denominator * d2.numerator);
            }

            public override string ToString()
            {
                return $"{numerator} / {denominator}";
            }
        }
        static void Main(string[] args)
        {
            Decimal d1 = new Decimal(2, 5);
            Decimal d2 = new Decimal(5, 10);
            Console.WriteLine($"d1 = {d1.ToString()} = {d1.DecimalValue}");
            Console.WriteLine($"d2 = {d2.ToString()} = {d2.DecimalValue}");
            Console.WriteLine($"d1 + d2 = {(d1 + d2).ToString()}");
            Console.WriteLine($"d1 - d2 = {(d1 - d2).ToString()}");
            Console.WriteLine($"d1 * d2 = {(d1 * d2).ToString()} = {(d1 * d2).Simplification().ToString()}");
            Console.WriteLine($"d1 / d2 = {(d1 / d2).ToString()} = {(d1 / d2).Simplification().ToString()}");

            Decimal d3 = new Decimal(6, 16);
            Console.WriteLine($"d3 = {d3.ToString()} = {d3.Simplification().ToString()}");
            Console.ReadKey();
        }
    }
}
