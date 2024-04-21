using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 43;
            int kol = 0;
            int b = 0;
            string a = Convert.ToString(n);
            for(int i = 0; i < a.Length; i++)
            {
                kol++;
            }
            char[] word = a.ToCharArray();
            
            for (int i = 100; i > 0; i--)
            {
                if (word[0] == i)
                {
                   b= i;
                    Console.WriteLine(b);
                   
                }
                else if (word[1] == i)
                {
                    b= i;
                    Console.WriteLine(b);
                }

            }
            
            Console.ReadKey();
        }
    }
}
