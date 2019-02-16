using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //sozdayu klass StreamReader dlya s4ityvaniya teksta iz text file
            StreamReader str = new StreamReader(@"C: \Users\Rustam\source\repos\Week 2\Task 1\index.txt");
            //s4ityvaem tekstovyi fail do konca i sohranyaem v peremennuyu string
            string s = str.ReadToEnd();
            int k = (s.Length - 1);
            for (int i = 0; i < (s.Length / 2); i++)
            {
                if (s[i] != s[k])
                {
                    Console.WriteLine("No");
                    Console.ReadKey();
                    return;
                }
                k--;
            }
            Console.WriteLine("Yes");
            Console.ReadKey();
        }
    }
}
