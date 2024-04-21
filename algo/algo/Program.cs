using System;

namespace algo
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
            Console.ReadKey();
        }
        static void start()
        {
            int ves, num;
            Console.WriteLine("У нас есть 4 предмета их вес и цена ");
            Console.WriteLine("Напишите их вес и цену: ");
            int[] mas = new int[4];
            int[] mas2 = new int[4];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                mas[i] = rnd.Next(0, 11);
                mas2[i] = rnd.Next(0, 11);
                Console.Write(mas[i] + ","+mas2[i] + " ");
            }
           
           
           
        }
    }
}
