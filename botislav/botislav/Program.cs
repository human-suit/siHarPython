using System;
using System.Collections.Generic;
using System.Threading;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Exception;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace botislav
{
    class Program
    {
        private static VkApi vkapi = new VkApi();
       
        static void Main(string[] args)
        {
            Console.Title = "bot";
            Auth();
            Flooder();
           
            Console.ReadKey();
        }
        public static void Auth()
        {
            Console.WriteLine("Key");
            var key = Console.ReadLine();
            ApiAuthParams api = new ApiAuthParams()
            {
                AccessToken = key,
                Settings = Settings.All
            };

            try
            {
                vkapi.Authorize(api);
                if (vkapi.IsAuthorized)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("Error");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Flooder()
        {
            var phrases = new List<String>{  "Hello, world..." };
            Console.WriteLine("Interval = ");
            var delay = int.Parse(Console.ReadLine());
            Console.WriteLine("Number chat = ");
            var chat = long.Parse(Console.ReadLine());

            while (true)
            {
                vkapi.Messages.Send(new MessagesSendParams()
                {
                    ChatId = chat,
                    Message = phrases.ToString(),
                    RandomId = new Random().Next()

                });
                Thread.Sleep(delay);
            }
           

        }
    }
}
