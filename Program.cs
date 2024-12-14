using Mediator_Pattern;
using System;

namespace ChatSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chatMediator = new ChatMediator();

            User user1 = new User("Алиса", chatMediator);
            User user2 = new User("Боб", chatMediator);
            User user3 = new User("Чарли", chatMediator);

            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);

            user1.SendMessage("Привет всем!"); 
            user2.SendMessage("Привет, Алиса!", "Алиса"); 
            user3.SendMessage("Как дела, Боб?", "Боб"); 

            Console.WriteLine();

            user1.ShowMessageHistory();
            user2.ShowMessageHistory();
            user3.ShowMessageHistory();

            Console.WriteLine();

            chatMediator.RemoveUser(user2);
            user1.SendMessage("Боб покинул чат."); 
        }
    }
}

