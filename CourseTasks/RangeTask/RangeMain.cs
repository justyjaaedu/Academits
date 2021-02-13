using System;

namespace RangeTask
{
    class RangeMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение начала числового диапазона:");
            double from1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение конца числового диапазона:");
            double to1 = Convert.ToDouble(Console.ReadLine());

            Range range1 = new Range(from1, to1);

            Console.WriteLine("Длина диапазона равна: " + range1.GetLength());

            Console.WriteLine("Введите число для проверки входа в диапазон: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (range1.IsInside(number))
            {
                Console.WriteLine("Число входит в диапазон");
            }
            else
            {
                Console.WriteLine("Число не входит в диапазон");
            }

            Console.WriteLine();
            Console.WriteLine("Вторая часть задания.");

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
                Console.WriteLine("Интервал пересечения: [{0},{1}]", intersectionRange.From, intersectionRange.To);
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

            Range[] differenceRange = range1.GetDifferenceRange(range2);

            if (differenceRange == null)
            {
                Console.WriteLine("Разности нет.");
            }
            else
            {
                switch (differenceRange.Length)
                {
                    case 1:
                        Console.WriteLine("Результат разности интервалов: [{0},{1}]", differenceRange[0].From, differenceRange[0].To);
                        break;
                    case 2:
                        Console.WriteLine("Результат разности интервалов: [{0},{1}],[{2},{3}]", differenceRange[0].From, differenceRange[0].To, differenceRange[1].From, differenceRange[1].To);
                        break;
                }
            }
        }
    }
}