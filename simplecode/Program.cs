using System;

namespace simplecode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите программу, вычисляющую среднюю арифметическую двух чисел.");
            Console.Write("Первое число = ");                                                           var OneNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Второе число = ");                                                           var TwoNumber = Convert.ToDouble(Console.ReadLine());
                                                                                                        var MediumArithmetic = (OneNumber + TwoNumber) / 2;
            Console.WriteLine($"Средняя арифметическая = {MediumArithmetic}");
        }
    }
}
