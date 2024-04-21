using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class bot
    {
        public string Name;
        bool IsHello = false;
        public bool IsWork = false;
        public void Hello()
        {
            Console.WriteLine("Hello my name is " + Name);
            IsHello = true;
        }
        public void StartMain()
        {
            IsWork = true;
            while (IsWork)
            {
                var message = Console.ReadLine();
                Console.WriteLine($"yES { message } ");
            }

        }
        public void Prov()
        {
            if (IsHello)
            {
                 
            }
            else
            {

            }
        }
    }
}
