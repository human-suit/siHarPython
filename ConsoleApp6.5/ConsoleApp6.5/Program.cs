using System;

namespace ConsoleApp6._5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Напишите строку для изменений = ");
            string s1 = Console.ReadLine();
            int kol = 0, raz,o=0; ;
            char[] mas = s1.ToCharArray();
           
                   for(int i = 0; i < s1.Length; i++)
                    {
                if (s1[i] == ' ')
                {
                    kol++;
                }
                    }
            raz = kol / 2;
            raz = raz + 1;
            for (int i = 0; i < s1.Length; i++)
            {
                if(s1[i]==' ')
                {
                o++;
                if (o == raz)
                {
                    break;
                }
                }
              
                else
                Console.Write(s1[i]);
                
            }
              
            Console.ReadKey();
           

        }
    }
}
