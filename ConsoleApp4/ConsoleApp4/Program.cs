using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Text Заглавными буквами");
            string s1=Console.ReadLine();
            char s2 = 'A';
            int kol = 0,a=0;
            char[] word = s1.ToCharArray();
            int s = s1.Length;
            for (int i = 0; i < s; i++)
            {
                kol++;
                
               if(s1[i] == ' ')
                {
                    for(int j = kol; j >= 0;j--)
                    {
                        if (s1[j] == 'А')
                        {
                            a += 1;
                            s1 = s1.Remove(0, kol);
                            s = s - kol;
                            i = 0;
                            kol = 0;
                            j = 0;
                          
                        }
           
                    }
                   
                }
                
            }
           
            Console.WriteLine(a);
            Console.ReadKey();
           
            
        }
    }
}
