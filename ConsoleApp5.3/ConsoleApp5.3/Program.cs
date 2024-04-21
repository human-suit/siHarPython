using System;

namespace ConsoleApp5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, kol = 0,s=-1;
            Console.WriteLine("Pres number 1 and 2=");
            a = Convert.ToInt32(Console.ReadLine()); //перевожу из типа стринг в инт
            b = Convert.ToInt32(Console.ReadLine()); 

            for (int i = 0; i < 1; i++)
            {
                if (a <= 0 || b <= 0) //проверка на целое число
                {
                    Console.WriteLine("Error 001,number 1 or 2 <=0");
                    break;
                }
                else if (a > 0 && b > 0)
                {
                    int[,] mas = new int[a, b];
                    Random rnd = new Random();
                    Console.WriteLine("Проверка на элементы -все");
                    for (i = 0; i < a; i++) //Сначала выполняется внутрений цыкл 
                    {
                        for (int j = 0; j < b; j++) //переменные в строку ----
                        {
                            mas[i, j] = rnd.Next(-100, 101);
                            Console.Write(mas[i, j] + "\t");
                           
                        }
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(" ");

                    for (i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {

                            if (kol > b || kol < b) // если не набирается кол -число то возвращаем кол=0
                            {
                                kol = 0;
                            }
                            if (mas[i, j] < 0) //проверяем на наличие -число
                            {
                                kol++; 

                                if (kol == b) //если все числа минусы запоминаем его i
                                {
                                    s = i;
                                    kol = 0;

                                }


                            }
                        }
                    }

                    for (i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            if (i == s) // убераем строку в которой все -
                            {

                            }
                            else
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
