using System;

namespace Нахождение_функции
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, ok;

            Console.Write("Введите число: ");
            r = Convert.ToDouble(Console.ReadLine()); // считываем знач консоли

            if ((1 <= r) && (r <= 3)) {
                ok = 1; // задаем знач.
            }
            else if ((4 <= r) && (r <= 6)) {
                ok = 2; // задаем знач
            }
            else {
                ok = 3;
            }

            switch (ok) // передаем значение и выполняем действия далее
            {
                case 1:
                    ok = 2 * r + 6; // вычислыем и сокращаем
                    Console.WriteLine($"F = {ok}");
                    break;
                case 2:
                    ok = r * r + 5; // вычислыем и сокращаем
                    Console.WriteLine($"F = {ok}");
                    break;
                case 3:
                    ok = 1; // вычислыем и сокращаем
                    Console.WriteLine($"F = {ok}");
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    break;
            }

        }
    }
}