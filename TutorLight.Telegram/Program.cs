using System;
using Telegram.Bot;

namespace TutorLight.Telegram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var botClient = new TelegramBotClient("1967940705:AAEqcSmYKP1tXz8JqT-LQOTYwEPYzcikrKg");
            var me = botClient.GetMeAsync().Result;
            Console.WriteLine(
                $"Hello, World! I am user {me.Id} and my name is {me.FirstName}."
            );
        }
    }
}