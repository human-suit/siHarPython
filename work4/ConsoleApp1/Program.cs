using System;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, max = 0,max2=0;
            Console.WriteLine("Pres number 1 and 2=");
            a = Convert.ToInt32(Console.ReadLine()); //перевожу из типа стринг в инт
            b = a;
            int[,] mas = new int[a, b];//присваиваю числа a b к mas
            Random rnd = new Random();//создаю генератор случайных чисел
            for (int i = 0; i < 1; i++)
            {
                if (a <= 0 || b <= 0) //проверка на целое число
                {
                    Console.WriteLine("Error 001,number 1 or 2 <=0");
                }
                else if (a > 0 && b > 0)
                {
                    Console.WriteLine("Press nabor is number");
                    for (i = 0; i < a; i++) //Сначала выполняется внутрений цыкл 
                    {
                        for (int j = 0; j < b; j++) //переменные в строку ----
                        {
                            mas[i, j] = rnd.Next(0, 101);//генерирую случайные числа
                            Console.Write(mas[i, j] + "\t");
                        }
                        Console.WriteLine(" ");
                    }
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (max < mas[i, i])//если мак меньше числа то
                    {
                        max = mas[i, i];//присваиваю число к максимульному

                    }
                    if  (max2 < mas[i, b - i - 1])//если мак2 меньше числа то
                    {
                        max2 = mas[i, b - i - 1];//присваиваю число к максимульному2

                    }

                }
            }
            Console.WriteLine("Параллельной  max");
            Console.WriteLine(max);//вывожу мак число
            Console.WriteLine("Побочная max");
            Console.WriteLine(max2);//вывожу мак число
            Console.ReadKey();

        }
    }
}
