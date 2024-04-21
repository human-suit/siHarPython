using System;
using System.Globalization;
using System.Security.Cryptography;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Текст");
            string s1 = Console.ReadLine();//Вводим строку в консоль
            string[] mass = s1.Split(' ', ',');// переменная Split для разделения на пробелы и символы присваиваем к mass
            if (s1.Length > a)
            {
                for(int i = 0; i < s1.Length; i++)
                {
                    if (i < a)
                    {

                    }
                    else Console.Write(s1[i]);
                      
                }
            }
            if (s1.Length < a)
            {
                a = a - s1.Length;
                for (int i = 0; i < a; i++)
                {
                    Console.Write(".");
                }
                for (int i = 0; i < s1.Length; i++)
                {
                    Console.Write(s1[i]);
                }
                Console.WriteLine();
                Console.ReadKey();
            }
              

        }
    }
}
