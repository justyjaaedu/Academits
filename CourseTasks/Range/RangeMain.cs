using System;

namespace RangeTask1
{
    class RangeMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение начала числового диапазона:");
            double from = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение конца числового диапазона:");
            double to = Convert.ToDouble(Console.ReadLine());

            Range range = new Range(from, to);

            Console.WriteLine("Длина диапазона равна: " + range.GetLength());

            Console.WriteLine("Введите число для проверки входа в диапазон: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (range.IsInside(number))
            {
                Console.WriteLine("Число входит в диапазон");
            }
            else
            {
                Console.WriteLine("Число не входит в диапазон");
            }
        }
    }
}