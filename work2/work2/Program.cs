using System;

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("напишите выражение 5-3+2-3 ни больше ни меньше ");
            string s = "5-3+2-3";
            string str = Console.ReadLine();
            char[] mas = str.ToCharArray();
            int[] a = new int[str.Length];
            int[] b = new int[str.Length];
            int[] wor = new int[str.Length];
            for (int x = 0; x < 1; x++)
            {
                if (str.Length<s.Length|| str.Length>s.Length)
                {
                    Console.WriteLine("выражение либо меньше либо больше примера");
                    break;
                }
                else
                    for (int i = 0; i < str.Length; i++)
                    {

                        for (int j = 57; j >= 43; j--)
                        {
                            if ((char)mas[i] == j)
                            {
                                wor[i] = j;
                                switch (wor[i])
                                {
                                    case 57:
                                        a[i] = 9;
                                        break;
                                    case 56:
                                        a[i] = 8;
                                        break;
                                    case 55:
                                        a[i] = 7;
                                        break;
                                    case 54:
                                        a[i] = 6;
                                        break;
                                    case 53:
                                        a[i] = 5;
                                        break;
                                    case 52:
                                        a[i] = 4;
                                        break;
                                    case 51:
                                        a[i] = 3;
                                        break;
                                    case 50:
                                        a[i] = 2;
                                        break;
                                    case 49:
                                        a[i] = 1;
                                        break;
                                    case 48:
                                        a[i] = 0;
                                        break;



                                    default:
                                        Console.WriteLine(" ");
                                        break;
                                }

                            }

                        }

                    }
                int sum = 0;

                for (int j = 1; j < 2; j++)
                {
                    switch (wor[j])
                    {
                        case 43:
                            sum += a[0] + a[2];

                            break;
                        case 45:
                            sum += a[0] - a[2];

                            break;
                    }
                }
                for (int j = 3; j <= 4; j++)
                {
                    switch (wor[j])
                    {
                        case 43:
                            sum = sum + a[4];

                            break;
                        case 45:
                            sum = sum - a[4];

                            break;
                    }
                }
                for (int j = 5; j <= 6; j++)
                {
                    switch (wor[j])
                    {
                        case 43:
                            sum = sum + a[6];

                            break;
                        case 45:
                            sum = sum - a[6];

                            break;
                    }
                }
                int orvet = sum;
                Console.WriteLine("Ответ=" + orvet);
                Console.ReadLine();
            }



        }
    }
}

