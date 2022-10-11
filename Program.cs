using System;

namespace PasswordApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInteraction userInteraction = new UserInteraction();

            Console.WriteLine("Welcome to your Password App!");
            userInteraction.CallMainMenu();
        }
    }
}