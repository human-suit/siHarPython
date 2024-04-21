using System;

namespace ConsoleApp5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Pres number =");
            a = Convert.ToInt32(Console.ReadLine()); //перевожу из типа стринг в инт
            b = a;
            int[,] mas = new int[a, b];
            Random rnd = new Random();
            for (int i = 0; i < 1; i++)
            {
                if (a <= 0) //проверка на целое число
                {
                    Console.WriteLine("Error 001,number 1 or 2 <=0");
                }
                else if (a > 0)
                {
                    Console.WriteLine("Press nabor is number");
                    for (i = 0; i < a; i++) //Сначала выполняется внутрений цыкл 
                    {
                        for (int j = 0; j < b; j++) //переменные в строку ----
                        {
                            mas[i, j] = rnd.Next(0, 101);
                            Console.Write(mas[i, j] + "\t");
                        }
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(" ");
                    for (i = 0; i < a; i++) 
                    {
                        for (int j = 0; j < b; j++) 
                        { 

                            Console.Write(mas[j,a-i-1] + "\t");
                        }
                        Console.WriteLine(" ");
                    }
                   
                }
            }
            Console.ReadKey();

        }
    }
}
