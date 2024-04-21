using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;

namespace gamex
{
    class Program
    {
        static void Main(string[] args)
        {
            string list = "1|1,1|2,1|3,2|1,3|1,5|2,3|3,2|2,6|4,6|8,-2,-6,+5";
            menu(list);
           
            Console.ReadLine();
        }
        static void start()
        {
            clear();
            int k=6;
            string list2 = "";
            string list = "1|1,1|2,1|3,2|1,3|1,5|2,3|3,2|2,6|4,6|8,-2,-6,+5";
            Console.WriteLine("Введите свое имя:");
            string n = Console.ReadLine();
            clear();
            Console.WriteLine(n);
            string ruka = "";
            int ruk = 3;
            Console.SetCursorPosition(17, 0);
            int hero1 = 30, hero2 = 30;
            Console.WriteLine(hero1);
            Console.SetCursorPosition(17, 4);
            Console.WriteLine(hero2);
            kard(list2,list);
            koloda(k);
            xod(list2,list,hero1);
          
        }
        static int koloda(int k)
        {
            Console.SetCursorPosition(30, 4);
            Console.WriteLine(k);
            return k;
        }
        static void kard(string list2,string list)
        {
            int k = 0;
            Random r = new Random();
            Console.SetCursorPosition(8, 7);
            for (int i = 0; i < 3; i++)
            {
                int rnd = r.Next(0, 10);
                Console.Write("   ");
                for (int j = 0; j < list.Length; j++)
                {
                    if (list[j] == '|')
                    {
                        if (k == rnd)
                        {
                            Console.Write(list[j - 1]);
                            Console.Write(list[j]);
                            Console.Write(list[j + 1]);
                            list2 += list[j - 1];
                            list2 += list[j];
                            list2 += list[j + 1];
                            list2 += " ";
                            k = 0;
                            break;

                        }
                        else k++;

                    }
                   

                }
                
            }
        }
        static void instruction(string list) 
        {
            clear();
            string list2 = "";
            int hero1 = 30, hero2 = 30;
            Console.SetCursorPosition(0, 0);
            Console.SetCursorPosition(17, 0);
            Console.WriteLine(hero1);
            Console.SetCursorPosition(17, 4);
            Console.WriteLine(hero2);
            Console.SetCursorPosition(22, 1);
            Console.WriteLine("Вы можете поставить защитника на стол, мест на столе 1-7");
            Console.SetCursorPosition(22, 4);
            Console.WriteLine("<- Ваше здоровье");
            Console.SetCursorPosition(22, 2);
            Console.WriteLine("Нужно привести к нулю здоровье соперника!");
            Console.SetCursorPosition(22, 3);
            Console.WriteLine("Нажмите '1' чтобы продолжить");
            Console.SetCursorPosition(22, 5);
            string one = Console.ReadLine();
            if (one == "1")
            {
                Console.SetCursorPosition(22, 4);
                Console.WriteLine("                   ");
                Console.SetCursorPosition(17, 6);
                Console.WriteLine("                                                ");
                Console.SetCursorPosition(22, 2);
                Console.WriteLine("                                                                                      ");
                Console.SetCursorPosition(22, 3);
                Console.WriteLine("                                                                                            ");
                Console.SetCursorPosition(22, 5);
                Console.WriteLine(" ");
                Console.SetCursorPosition(22, 2);
                Console.WriteLine("Выьерите от 1 до 7 место на столе");
                Console.SetCursorPosition(22, 3);
                int p = Convert.ToInt32(Console.ReadLine());
                if (p > 7 || p < 0)
                {
                    Console.SetCursorPosition(22, 2);
                    Console.WriteLine("Error");
                    restart(list);
                }
                else
                Console.SetCursorPosition(22, 2);
                Console.WriteLine("                                   ");
                stol(p);
                Console.WriteLine("3|1");
                xod(list2,list,hero1);
            }
            else restart(list);
        }
        static void xod(string list2,string list,int hero1)
        {
            int k = 0;
            int v = 0;
            Console.SetCursorPosition(22, 2);
            Console.WriteLine("1-Aтака , 2-Пропустить, 3-выставить на стол защитника");
            Console.SetCursorPosition(22, 3);
            string x = Console.ReadLine();
            if (x == "1")
            {
                atac(list,"3|1",hero1);
            }
            if (x == "2")
            {
               
            }
            if (x == "3")
            {
                Console.SetCursorPosition(22, 4);
                Console.WriteLine("Выберите защитника в руке");
                v = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < 3; i++)
                {
                    if (v == i)
                    {
                        for(int j = 0; j < list2.Length; j++)
                        {
                            if (list[j] == ' ')
                            {
                                if (k == v)
                                {
                                  
                                    if (k == v)
                                    {
                                        Console.SetCursorPosition(14, 3);
                                        Console.Write(list[j - 3]);
                                        Console.SetCursorPosition(14, 4);
                                        Console.Write(list[j - 2]);
                                        Console.SetCursorPosition(14, 5);
                                        Console.Write(list[j - 1]);
                                    }
                                }
                                else k++;
                            
                              
                            }
                            
                        }
                    }
                }
                xod(list2, list, hero1);
                
            }
        }
        static int stol(int x)
        {
            Console.SetCursorPosition(14+x, 3);
            return x;
        }
        static void clear()
        {
            Console.Clear();
        }
        static string atac(string list,string person,int hero1)
        {
            int a = 0;
            for(int i = 0; i < 10; i++)
            {
                if (person[0] == '1')
                {
                    a = 1;
                    break;
                }
                if (person[0] == '2')
                {
                    a = 2;
                    break;
                }
                if (person[0] == '3')
                {
                    a = 3;
                    break;
                }
                if (person[0] == '4')
                {
                    a = 4;
                    break;
                }
                if (person[0] == '5')
                {
                    a = 5;
                    break;
                }
                if (person[0] == '6')
                {
                    a = 6;
                    break;
                }
                if (person[0] == '7')
                {
                    a = 7;
                    break;
                }
                if (person[0] == '8')
                {
                    a = 8;
                    break;
                }
                if (person[0] == '9')
                {
                    a = 9;
                    break;

                }

            }
          
              
                hero1 = hero1 - a;
                Console.SetCursorPosition(17, 0);
                Console.WriteLine(hero1);
            win(list,hero1);
            return person;
            

        }
        static void restart(string list)
        {
            Console.SetCursorPosition(22, 3);
            Console.WriteLine("Перезагрузить уровень? 1-да или 2-нет");
            Console.SetCursorPosition(22, 5);
            string e = Console.ReadLine();
            if (e == "1" || e == "да" || e == "ДА" || e == "Yes" || e == "yes")
            {
                clear();
                instruction(list);
            }
            else clear();  menu(list);
        }
        static void win(string list,int hero1)
        {
            string list2 = "";
            if (hero1 < 0 || hero1 == 0)
            {
                Console.SetCursorPosition(22, 4);
                Console.WriteLine("You win");
                restart(list);
            }
            else xod(list2,list,hero1);
        }
        static void menu(string list)
        {
            Console.WriteLine("Start - 1");
            Console.WriteLine("Instruction - 2");
            Console.WriteLine("Kolektion - 3");
            Console.WriteLine("Bye kard - 4");
            Console.WriteLine("Exit - 5");
            string b = Console.ReadLine();
            if (b == "2")
            {
                instruction(list);
            }
            if (b == "3")
            {
                kolek(list);
            }
            if (b == "1")
            {
                start();
            }
            if (b == "5")
            {
                restart(list);
            }
            else
                Console.WriteLine("EXit");
        }
        static void kolek(string list)
        {
            clear();
            Console.WriteLine("Your cards ->");
            for(int i = 0; i < list.Length; i++)
            {
                if (list[i] == ',')
                {
                    Console.Write(" ");
                }
                else Console.Write(list[i]);

            }
            Console.WriteLine("");
            Console.WriteLine("1-Exit");
            string k = Console.ReadLine();
            if (k == "1")
            {
                clear();
                menu(list);
            }
            else kolek(list);
        }
    }
}
