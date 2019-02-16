using System;
using System.IO;
namespace task2
{
    class Program
    {
        //piwu funkciyu dlya proverki na prime
        public static bool isprime(int b)
        {
            if (b == 1)
            {
                return false;
            }
            for (int i = 2; i * i <= b; ++i)
            {
                if (b % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            //sozdayu klass StreamReader dlya 4tenya text file
            StreamReader str = new StreamReader(@"C:\Users\Rustam\source\repos\Week 2\Task2\input.txt");
            //sozdayu klass Streamwrite dlya zapisi v text file
            StreamWriter st = new StreamWriter(@"C:\Users\Rustam\source\repos\Week 2\Task2\output.txt");
            string[] s = str.ReadToEnd().Split();
            int[] arr = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (isprime(arr[i]) == true)
                {
                    st.Write(arr[i] + " ");
                }
            }
            st.Close();
        }
    }
}