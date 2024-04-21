using System;
using System.Globalization;
using System.Security.Cryptography;

namespace _6._5_ыы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Текст Заглавными буквами");
            string s3 = ".txt,.png,.doc,.jpg,.mp3,.rar,.7z,.docx,.avi";//создаю стринг с Расширениями файлов
            string[] mas2 = s3.Split(',');//переменная Split для разделения на пробелы и символы присваиваем к mas2
            string word = " ";
            char v = ','; //создаю переменную для замены
            string s1 = Console.ReadLine();//Вводим строку в консоль
            for(int i = 0; i < s1.Length; i++)//заменяю все символы \ на ,
            {
                if (i == 2)//кроме самой 1 \
                {

                }
                else if (s1[2] == s1[i])//замена на ,
                {
                    s1 = s1.Replace(s1[i], v);
                }
            }
            string[] mas = s1.Split(',', ' ');// переменная Split для разделения на пробелы и символы присваиваем к mas
            string result = " ";
            foreach (string mass in mas2)//перебираю каждое слово mas2
            {
                word = mass.ToString();

            foreach (string text in mas)//перебираю каждое слово mas
                {
                if (text.Contains(word))//если есть в маs2 слово mas то выписываю его
                    {
                        Console.WriteLine(text);
                        result = text;
                        break;
                    }

            }
            
            }
            for(int i = 0; i < result.Length; i++)//создаю цыкл для убирания расширения файла
            {
                if (result[i] == '.')//если есть . то останавливаем цыкл
                {
                    break;
                }
                else Console.Write(result[i]);
            }
            

                
        }





    }
    }
