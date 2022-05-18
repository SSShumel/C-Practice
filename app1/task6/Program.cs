using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите B(оно должно быть больше А): ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            double h = (b - a) / Convert.ToDouble(m);
            Console.WriteLine("Шаг {0:f2}",h);
            while (a <= b)
            {
                Console.WriteLine("{0:f2}",Math.Sin(Math.Pow(a, 2)));
                a += h;
            }
        }
    }
}
