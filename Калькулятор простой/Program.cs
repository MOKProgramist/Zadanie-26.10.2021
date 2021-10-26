using System;

namespace Калькулятор_простой
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, ok;
            string oper; // знак операции 

            Console.Write("Введите первый операнд: ");
            x = Convert.ToDouble(Console.ReadLine()); // считываем знач консоли

            Console.Write("Введите знак операции: ");
            oper = Console.ReadLine(); // считываем знач консоли

            Console.Write("Введите второй операнд: ");
            y = Convert.ToDouble(Console.ReadLine()); // считываем знач консоли

            switch (oper) // передаем значение и выполняем действия далее
            {
                case "+":
                    ok = Math.Round(x + y, 3); // вычислыем и сокращаем
                    Console.WriteLine($"x{oper}y = {ok}");
                    break;
                case "-":
                    ok = Math.Round(x - y, 3); // вычислыем и сокращаем
                    Console.WriteLine($"x{oper}y = {ok}");
                    break;
                case "*":
                    ok = Math.Round(x * y, 3); // вычислыем и сокращаем
                    Console.WriteLine($"x{oper}y = {ok}");
                    break;
                case "/":
                    if (y == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                        return;
                    }
                    ok = Math.Round(x / y, 3); // вычислыем и сокращаем
                    Console.WriteLine($"x{oper}y = {ok}");
                    break;
                default:
                    Console.WriteLine("Оператор не найден, ошибка");
                    break;
            }

            Console.ReadLine(); // задерживаем консоль
        }

    }
}
