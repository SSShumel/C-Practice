using System;
using System.IO;

namespace taskDop3
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = "O:\\";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            Directory.CreateDirectory("O:\\Exmple_30tp");

            Directory.CreateDirectory("O:\\Exmple");
            string file1 = "O:\\Exmple\\file1";
            File.WriteAllText(file1,"1 файл");
            string file2 = "O:\\Exmple\\file2";
            File.WriteAllText(file2,"2 файл");
            string file3 = "O:\\Exmple\\file3";
            File.WriteAllText(file3,"3 файл");

            FileInfo fileInf1 = new FileInfo(file1);
            if (fileInf1.Exists)
            {
                fileInf1.CopyTo("O:\\Exmple_30tp\\copy_file1", true);
            }

            FileInfo fileInf2 = new FileInfo(file2);
            if (fileInf2.Exists)
            {
                fileInf2.CopyTo("O:\\Exmple_30tp\\copy_file2", true);
            }

            FileInfo fileInf3 = new FileInfo(file3);
            if (fileInf3.Exists)
            {
                fileInf3.CopyTo("O:\\Exmple_30tp\\copy_file3", true);
            }

            File.SetAttributes("O:\\Exmple_30tp\\copy_file1", FileAttributes.Hidden);
            File.SetAttributes("O:\\Exmple_30tp\\copy_file2", FileAttributes.Hidden);
            File.SetAttributes("O:\\Exmple_30tp\\copy_file3", FileAttributes.Hidden);
        }
    }
}