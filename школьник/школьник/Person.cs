using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace школьник
{
   public class Person
    {
        public string name;
        public int age;
        public string nameByz;
        public string spec;
        public Person(string name, string nameByz, string spec) : this(name, 18, nameByz, spec) 
        {
           
        }
        public Person(string name,int age,string nameByz,string spec) 
        {
            
            if (name == "" || name ==" ")
            {
                Console.WriteLine("Error 001");
            }
            else
        
            if (age >= 16 && age <= 25)
            {
                Console.WriteLine("Название вуза:");
                nameByz = Console.ReadLine();
                Console.WriteLine("Название Специальности:");
                spec = Console.ReadLine();
            }
           else if (age < 16 && age > 0)
            {
               
            }
            else Console.WriteLine("Возраст не может быть <0, >100");
            this.name = name;
            this.age = age;
            this.nameByz = nameByz;
            this.spec = spec;
        }
       
        public void info()
        {
            if (age <= 0 || age > 100 )
            {
                Console.WriteLine("Error 002");
            }
            else if(age > 0 && age < 16)
            {
               

            }
            else if (age >= 16 && age <= 25)
            {
                Console.WriteLine($"Имя: {name} Возраст {age}  Название вуза: {nameByz} Специальность {spec}");
            }
            else 
            Console.WriteLine("Error 005");
        }
    }
}
