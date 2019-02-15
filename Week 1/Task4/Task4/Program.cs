using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; // peremennye
            int[] arr1 = new int[10000]; // array
            n = Convert.ToInt32(Console.ReadLine()); // kol-vo elementov v array input

            for (int i = 1; i <= n; i++) // from 0 to n do cycle
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write( "[*]" ); // out with double array element
                }
                Console.Write("\n");
            }
        }
    }
}