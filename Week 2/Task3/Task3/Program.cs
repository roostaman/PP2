using System;
using System.IO;

namespace task3
{
    class Program
    {
        //sozdayu funkciyu dlya sozdanie tabov
        public static void PrintSpaces(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("      ");
            }
        }
        //sozdayu funciyu dlya vyvedeniya na konsol vseh papok i failov po zadannomu puti
        public static void Director(DirectoryInfo dir, int a)
        {
            foreach (FileInfo f in dir.GetFiles())
            {
                PrintSpaces(a);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                PrintSpaces(a);
                Console.WriteLine(d.Name);

                Director(d, a + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo df = new DirectoryInfo(@"C:\Users\Rustam\source\repos\Week 2\Task3");
            int b = 0;
            Director(df, b);
            Console.ReadKey();
        }
    }
}