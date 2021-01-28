using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeTask
{
    class RangeMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения начала числового диапазона:");
            double from = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значения конца числового диапазона:");
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