using System;
using System.Linq;
using Tutor.Domain.Entities;
// using Telegram.Bot;
// using Telegram.Bot.Types;
using TutorLight.API.Data;
using TutorLight.Service;

namespace TutorLight.Telegram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            
            using (TutorContext db = new TutorContext())
            {
                // создаем два объекта User
                // User user1 = new User {Id = 2, Login = "test1", Email = "test1@mail.com", Password = "test"};
                // User user2 = new User {Id = 3, Login = "test2", Email = "test2@mail.com", Password = "test"};

                // добавляем их в бд
                // db.Users.AddRange(user1, user2);
                // db.SaveChanges();
                
                var users = db.Users.ToList();
                Console.WriteLine("Users list:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Login} - {u.Email}");
                }
            }

            // получение данных
            // using (TutorContext db = new TutorContext())
            // {
            //     // получаем объекты из бд и выводим на консоль
            //     var users = db.Users.ToList();
            //     Console.WriteLine("Users list:");
            //     foreach (User u in users)
            //     {
            //         Console.WriteLine($"{u.Login} - {u.Email}");
            //     }
            // }
            
            // var botClient = new TelegramBotClient("token");
            // var me = botClient.GetMeAsync().Result;
            // Console.WriteLine(
            //     $"Hello, World! I am user {me.Id} and my name is {me.FirstName}."
            // );
        }
    }
}