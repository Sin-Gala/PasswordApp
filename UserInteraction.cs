using System;

namespace PasswordApp
{
    public class UserInteraction
    {
        bool launched = false;

        public void CallMainMenu()
        {
            if (launched)
                Console.Clear();
            else
                launched = true;

            Console.WriteLine("What do you wish to do?");
            Console.WriteLine("\n1: See a Password \n2: Add a Password \n3: Edit a Password " +
                "\n4: Delete a Password \n5 Delete all datas");

            switch (Console.ReadLine())
            {
                case "1": // See Password
                    SeePassword();
                    break;
                case "2": // Add Password
                    AddPassword();
                    break;
                case "3": // Edit Password
                    EditPassword();
                    break;
                case "4": // Delete Password
                    RemovePassword();
                    break;
                case "5": // Delete all datas
                    DeleteAll();
                    break;
                default:
                    Console.WriteLine("Please enter a valid command");
                    Console.ReadKey();
                    CallMainMenu();
                    break;
            }
        }

        private void SeePassword()
        {
            Console.WriteLine("See");
        }

        private void AddPassword()
        {
            Console.WriteLine("Add");
        }

        private void RemovePassword()
        {
            Console.WriteLine("Remove");
        }

        private void EditPassword()
        {
            Console.WriteLine("Edit");
        }

        private void DeleteAll()
        {
            Console.WriteLine("Delete all");
        }
    }
}
