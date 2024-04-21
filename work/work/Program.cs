using System;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Text");
            string s1 = Console.ReadLine();
            int kol = 0, yes = 0 ;
            char[] word = s1.ToCharArray();
            string exit = " ";
            s1 = s1 + exit;
            int s = s1.Length;
            Console.WriteLine(s1);
            for (int i = 0; i < s; i++)
            {
                kol++;
               if(s1[i]==' ')
                {
                   
                    if (s1[0] == s1[kol-2])
                    {
                        
                        yes++;
                        
                        s1=s1.Remove(0, kol);
                       
                        s= s - kol;
                        i = 0;
                        kol = 0;
                        
                       
                    }
                  
                }
                    

            }

            Console.WriteLine(yes);
            Console.ReadKey();








        }
    }
}

