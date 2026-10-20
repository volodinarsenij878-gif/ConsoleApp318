using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program158
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Введите букву направления (N/S/W/E) или Q для выхода: ");
                string? input = Console.ReadLine()?.Trim().ToUpper();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Пустой ввод. Попробуйте ещё раз.");
                    continue;
                }

                if (input == "Q")
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }

                if (input.Length != 1)
                {
                    Console.WriteLine("Ошибка: введите ровно одну букву.");
                    continue;
                }

                char direction = input[0];
                string result;

                if (direction == 'N')
                    result = "Север";
                else if (direction == 'S')
                    result = "Юг";
                else if (direction == 'W')
                    result = "Запад";
                else if (direction == 'E')
                    result = "Восток";
                else
                {
                    Console.WriteLine("Неверное направление. Попробуйте ещё раз.");
                    continue;
                }

                Console.WriteLine(result);
                break; // успешный ввод — выходим из цикла
            }
        }
    }
}
