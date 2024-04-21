using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Person
    {
        public int x;
        public int y;
        public int p;

        public Person() : this(0, 0, 0)
        {

        }
        public Person(int x, int y, int p)
        {
            Console.WriteLine("Введите точку");
            x = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("Error");
            }


            else Console.WriteLine("Вторая точка:");
            y = Convert.ToInt32(Console.ReadLine()); ;
            if (y < 0)
            {
                Console.WriteLine("Error");
            }
            else
                p = x * y / 2;



            this.x = x;
            this.y = y;
            this.p = p;

        }
        public void info()//выводим данные на консоль
        {
            if (y > 0)
            {
                Console.WriteLine($"Первая точка: {x} Вторая точка: {y} Площадь {p}");

            }

        }
    }
}
