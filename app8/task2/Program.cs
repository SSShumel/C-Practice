using System;

namespace task2
{
    enum Post
    {
        Uborshica = 60,
        Aficant = 120,
        Povar = 130,
        Director = 80
    }

    class Accauntan
    {
        public string name;
        public bool AskForBonus(Post worker, int hours)
        {
            return (hours > (int)worker);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Уборщица должна работать в месяц { (int)Post.Uborshica} часов");
            Console.WriteLine($"Продавец должен работать в месяц { (int)Post.Aficant} часов");
            Console.WriteLine($"Тракторист должен работать в месяц { (int)Post.Povar} часов");
            Console.WriteLine($"Директор должен работать в месяц { (int)Post.Director} часов");

            Console.WriteLine();

            Accauntan vlad = new Accauntan();
            vlad.name = "Владичара";

            if (vlad.AskForBonus(Post.Director, 80))
                Console.WriteLine($"{Post.Director} {vlad.name} достоин премии");
            else
                Console.WriteLine($"{Post.Director} {vlad.name} не достоин премии");

            Console.WriteLine();

            Accauntan galina = new Accauntan();
            galina.name = "Галина";

            if (galina.AskForBonus(Post.Aficant, 130))
                Console.WriteLine($"{Post.Aficant} {galina.name} достоина премии");
            else
                Console.WriteLine($"{Post.Aficant} {galina.name} не достоина премии");
        }
    }
}
