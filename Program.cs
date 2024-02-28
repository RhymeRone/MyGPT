using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI_API;
using OpenAI_API.Models;

namespace MyGPT
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            OpenAIAPI api = new OpenAIAPI(new APIAuthentication("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")); // örnektir key, çalışmaz
            var chat = api.Chat.CreateConversation();
            chat.Model = Model.ChatGPTTurbo;
            chat.RequestParameters.Temperature = 0;
            string response;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Yapay Zeka: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Nasıl Yardımcı Olabilirim ?");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Sen: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                chat.AppendUserInput(Console.ReadLine());
                response = await chat.GetResponseFromChatbotAsync();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Yapay Zeka: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(response);
            }
        }

        
    }
}
