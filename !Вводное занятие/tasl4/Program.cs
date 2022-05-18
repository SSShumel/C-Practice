using System;

namespace tasl4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int diff = a - b;
            int mult = a * b;
            Console.WriteLine($"сумма: {sum} разность: {diff} произведение: {mult}");
        }
    }
}
