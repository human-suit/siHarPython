using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sred = 0,s=18,kol=0;
            for (int i = 0; i < 5; i++)
            {
                kol++;
                if (i == 0)
                {
                    s = 0;
                }
                else if (i == 1)
                {
                    s = 18;
                }
                else 
                s += 18;

                Human n = new Human();
                Console.SetCursorPosition(i + s, 0);
                Console.Write("Press name =");
                Console.SetCursorPosition(i + 12 +s , 0);
                string x = Console.ReadLine();
                n.SetName(x);
                if (x == " " || x == "")
                {
                    Console.WriteLine("Error");
                    break;
                }
                Console.SetCursorPosition(i + s , 1);
                Console.Write("Press age =");
                Human a = new Human();
                Console.SetCursorPosition(i + 11 + s, 1);
                int y = Convert.ToInt32(Console.ReadLine());
                if (y < 0 || y > 100)
                {
                    Console.WriteLine("Error");
                    break;
                }
                Console.SetCursorPosition(i + s, 2);
                Console.Write("Press weight =");
                Human w = new Human();
                Console.SetCursorPosition(i + 14 + s, 2);
                int d = Convert.ToInt32(Console.ReadLine());
                if(d<0 || d > 300)
                {
                    Console.WriteLine("Error");
                    break;
                }
                sred += y;
                a.Setage(y);
            }
            if (kol == 5)
            {
                Console.WriteLine("Average = " + sred / 5);
            }
           
        }
    }
}
