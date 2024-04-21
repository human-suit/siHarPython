using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p=0,i, max=0,maxs=0,min=0,hum=0;
            int[] a=new int[4];
            int[] b = new int[4];
            for (i = 0; i < 4; i++)
            {
                Console.Write(i + 1 + "," + "Вес =");
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (max < a[i])
                {

                    max = a[i];
                    p = i;
                    hum = max;
                    
                }
              
                Console.Write(i + 1 + "," + "Стоимь=");
                b[i] = Convert.ToInt32(Console.ReadLine());

                if (b[i] < 0 || a[i] < 0)
                {
                    Console.Write("Error Вес не может быть <0 и не может стоить <0"); break;
                }
            }
            
            up();
            for (i=1;i<11;i++)
            {

           
                Console.SetCursorPosition(13, i);
                    Console.WriteLine(i);
                if (i >= max)
                {
                    Console.SetCursorPosition(16, i);
                    Console.WriteLine("1");
                    Console.SetCursorPosition(19, i);
                    Console.WriteLine(b[p]);
                }
                
                else Console.SetCursorPosition(16, i);
                Console.WriteLine("0");
              
            }
            tabl2(a, b, max, p, hum);
            delit(a, p,max);
            maxi(a, b, max, p);
            Console.ReadKey();
            
        }
        static void up()
        {
            int x = 10, y = 13;
            for(int i = 4; i > 0; i--)
            {
            Console.SetCursorPosition(13, 0);
            Console.WriteLine("s");
            Console.SetCursorPosition(x+=6, 0);
            Console.WriteLine("X"+i);
            Console.SetCursorPosition(y+=6, 0);
            Console.WriteLine("W"+i);
            }
            


        }
        static void tabl2(int[] a,int[] b,int max,int p,int hum)
        {
           
            for (int i = 1; i < 11; i++)
            {

                if (i >= a[p])
                {
                    Console.SetCursorPosition(22, i);
                    Console.WriteLine("1");
                    Console.SetCursorPosition(25, i);
                    Console.WriteLine(b[p]);
                }
              
              
                
                else Console.SetCursorPosition(22, i);
                Console.WriteLine("0");
        }
            for (int i = 1; i < 11; i++)
            {
                if (i >= hum)
                {
                     Console.SetCursorPosition(22, i);
                    Console.WriteLine("0");
                }
            }

            }
              
            
            
        
        static void maxi(int[]a,int[]b,int max,int p) 
        {
            
            
            for (int i = 0; i < 4; i++)
            {

                if (a[i] > max)
                {
                    max = a[i];
                    p = i;
                   
                }      
            }
        }
        static void delit(int[]a,int p,int max)
        {
            for(int i = 0; i < 4; i++)
            {
                if (i == p)
                {
                    a[i] = 0;
                    max = 0;
                }
                
            }
        }
        
    }
}
