using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public int year;

        public Student(string name, string id)//sozdayu konstruktor s 2 paramentrami
        {
            this.name = name; //this piwetsya 4toby kompilator ne pereputal peremennye
            this.id = id;
        }
        
        public void print(int year) //sozdayu metod
        {
            Console.WriteLine("name:          " + name);
            Console.WriteLine("ID:            " + id);
            Console.WriteLine("Year of study: " + (++year));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string i = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Student st1 = new Student(s, i);
            st1.print(n);
            Console.ReadKey();
        }
    }
}
