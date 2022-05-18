using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            int number = Convert.ToInt32(Console.ReadLine());
            int mult = (number / 10 % 10) * (number % 10);
            Console.WriteLine(mult);
        }
    }
}
