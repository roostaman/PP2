using System;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //s4ityvayu put', gde nado sozdat' fail
            string path1 = Console.ReadLine();
            //s4ityvayu put', kuda nado skopirovat' fail 
            string path2 = Console.ReadLine();
            //kombiniruyu pervyi put' s nazvaniem faila
            path1 = Path.Combine(path1, "example.txt");
            //kombiniruyu vtoroi put' s nazvaniem faila
            path2 = Path.Combine(path2, "example.txt");
            //sozdayu fail po pervomu puti
            FileStream fs = File.Create(path1);
            //zakryvayu potok
            fs.Close();
            //kopiruyu fail iz path1 to path2
            File.Copy(path1, path2, true);
            //udalyayu fail po zadannomu puti
            File.Delete(path1);
        }
    }
}
