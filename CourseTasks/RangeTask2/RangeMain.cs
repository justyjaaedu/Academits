using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeTask2
{
    class RangeMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение начала первого числового диапазона:");
            double from1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение конца первого числового диапазона:");
            double to1 = Convert.ToDouble(Console.ReadLine());

            Range range1 = new Range(from1, to1);

            Console.WriteLine("Введите значение начала второго числового диапазона:");
            double from2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение конца второго числового диапазона:");
            double to2 = Convert.ToDouble(Console.ReadLine());

            Range range2 = new Range(from2, to2);

            Console.WriteLine("Проверка на пересечение диапазонов 1 и 2");

            Range intersectionRange = range1.GetIntersectionRange(range2);

            if (intersectionRange == null)
            {
                Console.WriteLine("Пересечения нет");
            }
            else
            {
                Console.WriteLine("Интервал пересечения: [{0},{1}])", intersectionRange.From, intersectionRange.To);
            }

            Console.WriteLine("Проверка на объединение диапазонов 1 и 2");

            Range[] unionRange = range1.GetUnionRange(range2);

            switch (unionRange.Length)
            {
                case 1:
                    Console.WriteLine("Результат объединения интервалов: [{0},{1}]", unionRange[0].From, unionRange[0].To);
                    break;
                case 2:
                    Console.WriteLine("Результат объединения интервалов: [{0},{1}],[{2},{3}]", unionRange[0].From, unionRange[0].To, unionRange[1].From, unionRange[1].To);
                    break;
            }
        }
    }
}
