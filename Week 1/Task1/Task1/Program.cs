using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int cnt=0, stno, j, p; // peremennye
            int[] arr = new int[10000]; // array

            stno = Convert.ToInt32(Console.ReadLine()); // kol-vo elementov v array input
            for(int i=0; i<stno; i++) // from 0 to stno do cycle
            {
                arr[i] = Convert.ToInt32(Console.ReadLine()); // first element of array input
                j = 2;
                p = 1;
                while (j < arr[i]) // while elem of array less than j
                {
                    if (arr[i] % j == 0) // if elem of array % to j = 0 do
                    {
                        p = 0;
                        break; // vyhod from cycle, because its not prime
                    }
                    j++; // j+1
                }

                if (p == 1 && arr[i]!=1) // if p=1 and elem of array not equal =1 do
                {
                    cnt++; // cnt+1 kolvo of prime numbers
                }
            }
            Console.Write(cnt+"\n"); // out kolvo of prime numbers

            for (int i = 0; i < stno; i++)
            {
                j = 2;
                p = 1;
                while (j < arr[i])// while elem of array less than j
                {
                    if (arr[i] % j == 0)// if elem of array % to j = 0 do
                    {
                        p = 0;
                        break;// vyhod from cycle, because its not prime
                    }
                    j++; // j+1
                }

                if (p == 1 && arr[i]!=1)// if p=1 and elem of array not equal =1 do
                {
                    Console.Write(arr[i] + " "); // out prime numbers
                }
            }

        }
    }
}
