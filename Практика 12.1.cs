
using System;

namespace Practise_12._1
{
    internal class Program
    {
        internal class Calculator
        {
            public static double Add(double a, double b)
            {
                return a + b;
            }

            public static double Subtract(double a, double b)
            {
                return a - b;
            }

            public static double Multiply(double a, double b)
            {
                return a * b;
            }

            public static double Divide(double a, double b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно.");
                    return double.NaN;
                }
                return a / b;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("11 + 6 = " + Calculator.Add(11, 6));
            Console.WriteLine("9 - 5 = " + Calculator.Subtract(9, 5));
            Console.WriteLine("4 * 4 = " + Calculator.Multiply(4, 4));
            Console.WriteLine("15 / 4 = " + Calculator.Divide(15, 4));
            Console.WriteLine("1 / 0 = " + Calculator.Divide(1, 0));
        }
    }

}
