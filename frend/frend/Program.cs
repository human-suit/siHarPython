using System;

namespace frend
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }
        static void start()
        {
            string w;
            Console.WriteLine("Press w");
            w = Console.ReadLine();
            if (w == "w")
            {
                random();
            }
            else Console.WriteLine("Error"); start();
        }
        static void random()
        {
            Random r = new Random();
            int cel = r.Next(0,3);
            Console.WriteLine(cel);
        }
    }
}
