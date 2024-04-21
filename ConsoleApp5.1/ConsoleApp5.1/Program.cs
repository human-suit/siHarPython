using System;

namespace ConsoleApp5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Pres number 1 and 2=");
            a = Convert.ToInt32(Console.ReadLine()); //перевожу из типа стринг в инт
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 1; i++)
            {
                if (a <= 0 || b <= 0) //проверка на целое число
                {
                    Console.WriteLine("Error 001,number 1 or 2 <=0");
                }
                else if(a>0 && b > 0)
                {
                        int[] nabor = new int[b];
                        Console.WriteLine("Press nabor is number");
                        for (i = 0; i < b; i++)  
                        {
                            nabor[i] = Convert.ToInt32(Console.ReadLine()); 
                        }
                        for (i = 0; i < a; i++) //Сначала выполняется внутрений цыкл 
                    {
                            for (int j = 0; j < b; j++) //переменные в строку ----
                        {
                                Console.Write(nabor[j] + " ");
                            }
                            Console.WriteLine(" ");
                        }
                }      
            }
            Console.ReadKey();
        }
    }
}
