using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];
            Random rn = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    a[i, j] = rn.Next(-9, 9);
            {
                Console.WriteLine("Исходный массив: ");
            }

            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                        Console.Write(" " + a[i, j]);
                    Console.WriteLine();
                }
                Console.WriteLine("---------");
            }

            int k = a[0, 4];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)

                {
                    k = a[0, i];
                    a[0, i] = a[4, i];
                    a[4, i] = k;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Полученный массив");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)

                    Console.Write(" " + k);
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
