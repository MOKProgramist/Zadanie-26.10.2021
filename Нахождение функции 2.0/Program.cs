using System;

namespace Нахождение_функции_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.Write("Введите число: ");
            x = Convert.ToDouble(Console.ReadLine()); // считываем знач консоли

            if (x < 0) {
                y = 1; // задаем знач.
            }
            else if ((0 <= x) && (x < 1)) {
                y = 2; // задаем знач
            }
            else {
                y = 3;
            }

            switch (y) // передаем значение и выполняем действия далее
            {
                case 1:
                    y = (Math.Pow((Math.Pow(x, 3) + 1), 2)); // вычисляем и сокращаем
                    Console.WriteLine($"y = {y}");
                    break;
                case 2:
                    y = 0; // вычисляем и сокращаем
                    Console.WriteLine($"y = {y}");
                    break;
                case 3:
                    y = Math.Abs(Math.Pow(x, 2) - (5 * x) + 1); // вычислыем и сокращаем
                    Console.WriteLine($"y = {y}");
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    break;
            }
        }
    }
}
