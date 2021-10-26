using System;

namespace Дни_недели
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Вваедите порядковый номер дня недели: ");
            a = Convert.ToInt32(Console.ReadLine()); // считываем значение с консоли

            switch (a)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Ошибка, такого дня недели нет");
                    break;
            }
            Console.ReadLine(); // задерживаем консоль
        }

    }
}
