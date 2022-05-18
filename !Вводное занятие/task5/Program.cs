using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число");
            int number = Convert.ToInt32(Console.ReadLine()); ;
            int newNumber = number / 1000 * 100 + number / 100 % 10 * 1000 + number / 10 % 10 + number % 10 * 10;
            Console.WriteLine(newNumber);
        }
    }
}
