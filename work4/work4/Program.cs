using System;
using System.Globalization;

namespace work4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int kol = 0, s = -1;
            Console.WriteLine("Введите 1 и 2 числа =");
            a = Convert.ToInt32(Console.ReadLine()); //перевожу из типа стринг в инт
            b = Convert.ToInt32(Console.ReadLine());
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
                        if (kol < b)
                        {
                            kol = 0;
                        }

                        for (int j = 0; j < b; j++) //переменные в строку
                        {
                            mas[i, j] = rnd.Next(-100, 100);//получаю рандомные числа
                            Console.Write(mas[i, j] + "\t");
                            if (mas[i, j] < 0)
                            {
                                kol++;
                                if (kol == b)
                                {
                                    s = i;

                                }
                            }

                        }
                        Console.WriteLine(" ");
                    }
                    Console.Write("№ с которым поменять=");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    if (s >= 0)//если все элементы с минусами то 
                    {
                        for (i = 0; i < a; i++)//создаю цыкл 
                        {
                            if (s == i)//проверяю если i=s то заменяю его на столбец с номером n
                            {
                                for (int j = 0; j < b; j++)
                                {
                                    Console.Write(mas[n, j] + "\t");
                                }
                                Console.WriteLine(" ");
                           
                            }
                            else if (n == i)//если это номер которого мы переместили то выводим то что заменили 
                            {
                                for (int j = 0; j < b; j++)
                                {
                                    Console.Write(mas[s, j] + "\t");
                                }
                                Console.WriteLine(" ");
                            }
                            else//в другом случае мы просто выводим все остальные элементы
                                for (int j = 0; j < b; j++)
                            {
                                Console.Write(mas[i, j] + "\t");
                            }
                            Console.WriteLine(" ");
                        }
                    }
                    else Console.WriteLine("НЕ все с минусами");//в друом случае выводим на консоль что не все с минусами
                }
                }
            
            
            Console.ReadKey();

        }
    }
}
