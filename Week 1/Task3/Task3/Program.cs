using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());//sozdayu peremennuyu i sohranu v nego kolvo vvodimyh 4isel
            
            string[] arr = Console.ReadLine().Split();//sozdayu massiv strok, s4ityvau s konsoli n 4isel i razdelyayu ih na kajdyi element massiva
            
            int[] a = new int[n * 2];//sozdayu massiv 4isel s razmerom n*2
            
            int k = 0;//sozdayu peremennuyu, 4toby ispolzovat ee pri zapolnenii massiva 4isel
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    //zapolniyayu massiv s povtoryayuwimsya 4islemi
                    a[k] = int.Parse(arr[i]);
                    k++;
                }
            }
            for (int i = 0; i < n * 2; i++)
            {
                //vyvoju na konsol
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}