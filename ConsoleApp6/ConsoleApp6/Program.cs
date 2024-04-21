using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите 1 и 2 числа =");
            a = Convert.ToInt32(Console.ReadLine()); //перевожу из типа стринг в инт
            b = Convert.ToInt32(Console.ReadLine());
            int k;
            int[,] mas = new int[a, b];//присваиваю числа к mas
            Random rnd = new Random();//Создаю генератор случайных чисел
            for (int i = 0; i < 1; i++)
            {
                if (a <= 0 || b <= 0) //проверка на целое число
                {
                    Console.WriteLine("Число 1 или 2 < или = 0");
                }
                else if (a > 0 && b > 0)
                {
                    for (i = 0; i < a; i++) //Сначала выполняется внутрений цыкл
                    {
                        for (int j = 0; j < b; j++) //переменные в строку
                        {
                            mas[i, j] = rnd.Next(0, 101);//получаю рандомные числа
                            Console.Write(mas[i, j] + "\t");
                        }
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine("Отчет с 0");
                    Console.WriteLine("Удалить=");
                    k = Convert.ToInt32(Console.ReadLine());//перевожу из типа стринг в инт
                    if (k < 0 || k > b)//проверяю по заданию
                    {
                        Console.WriteLine("Error");
                    }
                    else
                        for (i = 0; i < a; i++) //Сначала выполняется внутрений цыкл
                        {
                            if (i == k)
                            {
                                Console.WriteLine("");
                            }
                            else
                            for (int j = 0; j < b; j++) //переменные в строку
                            {
                              
                                Console.Write(mas[i, j] + "\t");
                            }
                            Console.WriteLine(" ");
                        }

                    

                }
            }
            Console.ReadKey();
        }
    }
}
