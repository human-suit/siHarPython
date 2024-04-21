using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите 1 и 2 числа =");
            a = Convert.ToInt32(Console.ReadLine()); //перевожу из типа стринг в инт
            b = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[a, b];//присваиваю числа к mas
            Random rnd = new Random();//Создаю генератор случайных чисел
            for (int i = 0; i < 1; i++)
            {
                int max, min;
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
                   
                    Console.WriteLine(" ");
                    for (i = 0; i < a; i++)
                    {
                        max = mas[i,0];
                        min = mas[i, 0];
                        for (int j = 0; j < b; j++)
                        {
                          
                            if (max < mas[i, j])
                            {
                                max = mas[i, j];
                            }
                            if (min > mas[i, j])
                            {
                                min = mas[i, j];
                            }
                           
                        }
                        for(int j = 0; j < b; j++)
                        {
                            if (max == mas[i, j])
                            {
                                Console.Write(min + "\t");
                            }
                            else if (min == mas[i, j])
                            {
                                Console.Write(max + "\t");
                            }
                            else
                                Console.Write(mas[i, j]+"\t");
                        }
                        
                        Console.WriteLine(" ");
                    }

                }
            }
            Console.ReadKey();



        }
    }
}