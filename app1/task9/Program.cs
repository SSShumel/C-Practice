using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsArithmeticProgression (int number)
            {
                if (number%10- number/10%10 == number / 10 % 10 - number / 100)
                {
                    return true;
                }
                return false;
            }

            Console.WriteLine("Введите трехзначное число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (IsArithmeticProgression(number))
            {
                Console.WriteLine($"Цифры числа {number} образуют арифмитическую прогрессию");
            }
            else
            {
                Console.WriteLine($"Цифры числа {number} не образуют арифмитическую прогрессию");
            }
        }
    }
}
