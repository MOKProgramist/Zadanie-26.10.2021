using System;

namespace Кальлятор_cos__sin__log
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, ok;
            string oper; // знак функции  


            Console.Write("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine()); // считываем знач консоли

            Console.WriteLine("Доступные операции: s - sin, c - cos, l - log"); // подсказка
            Console.Write("Введите функцию: ");
            oper = Console.ReadLine(); // считываем знач консоли

            switch (oper) // передаем значение и выполняем действия далее
            {
                case "s":
                    ok = Math.Sin(x); // вычислыем и сокращаем
                    Console.WriteLine($"Sin(x) = {ok}");
                    break;
                case "c":
                    ok = Math.Cos(x); // вычислыем и сокращаем
                    Console.WriteLine($"Cos(x) = {ok}");
                    break;
                case "l":
                    ok = Math.Log10(x); // вычислыем и сокращаем
                    Console.WriteLine($"Log(x) = {ok}");
                    break;
                default:
                    Console.WriteLine("Оператор не найден, ошибка!");
                    break;
            }

            Console.ReadLine(); // задерживаем консоль
        }

    }
}
