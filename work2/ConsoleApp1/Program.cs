using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите 2 предложения");
            string str = Console.ReadLine();
            string s2= Console.ReadLine();
            string[] mas = str.Split(' ',',','?');
            string[] mass = s2.Split(' ', ',', '?');
            int max = mas[0].Length;
            int maxx = mass[0].Length;
            string ma = mas[0];
            string mo = mass[0];

            for (int i = mas.Length - 1; i >= 0;i--)
            {
                if (mas[i].Length > max)
                {
                    max = mas[i].Length;
                    ma = mas[i];
                }
            }
            for (int i = mass.Length - 1; i >= 0; i--)
            {
                if (mass[i].Length > maxx)
                {
                    maxx = mass[i].Length;
                    mo = mass[i];
                }
            }
            for (int i = 0; i<1; i++)
            {
                if (mo == ma)
                {
                    Console.WriteLine("общие максимальные слова");
                    Console.WriteLine(mo+" "+ma);
                    break;
                }
                else
                    Console.WriteLine("нет совподений");
                break;
            }
           
            Console.ReadLine();
        }
    }
}
