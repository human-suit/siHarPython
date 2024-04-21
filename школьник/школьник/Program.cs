using System;

namespace школьник
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person(" "," "," ");
            Console.WriteLine("Ваше Имя:");
           tom.name = Console.ReadLine();
            Console.WriteLine("Ваш Возраст:");
            tom.age = Convert.ToInt32(Console.ReadLine());
            tom.info();
            Console.ReadLine();
           

        }
       
       
    }
}
