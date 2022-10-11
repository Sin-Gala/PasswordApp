using System;

namespace PasswordApp
{
    public class UserInteraction
    {
        public UserInteraction()
            => passwordDico = new PasswordDico(); // Need to use save files

        private PasswordDico passwordDico;
        private bool launched = false;

        public void CallMainMenu()
        {
            if (launched)
                Console.Clear();
            else
                launched = true;

            Console.WriteLine("What do you wish to do?");
            Console.WriteLine("\n1: See a Password \n2: Add a Password \n3: Edit a Password " +
                "\n4: Delete a Password \n5 Delete all datas");

            CheckMenuChoice();
        }

        private void CheckMenuChoice()
        {
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
                    CheckMenuChoice();
                    break;
            }
        }

        private void SeePassword()
        {
            Console.Clear();
            Console.WriteLine("See");
            Console.ReadKey();
            CallMainMenu();
        }

        private void AddPassword()
        {
            Console.Clear();

            Console.WriteLine("Enter the website name");
            string website = Console.ReadLine();
            Console.WriteLine("\nEnter your password");
            string password = Console.ReadLine();

            Console.WriteLine("Is this correct y/n: " +
                "\nWebsite: " + website + "\nPassword: " + password);

            switch (Console.ReadLine())
            {
                case "y":
                    // Validate and send the datas
                    passwordDico.AddDatas(new PasswordDatas(website, password));
                    CallMainMenu();
                    break;
                case "n":
                default:
                    // Cancel and go back main menu
                    CallMainMenu();
                    break;
            }
        }

        private void RemovePassword()
        {
            Console.Clear();

            Console.WriteLine("Enter the website name");
            string website = Console.ReadLine();

            passwordDico.RemoveDatas(website);
            CallMainMenu();
        }

        private void EditPassword()
        {
            Console.Clear();
            passwordDico.EditDatas(new PasswordDatas("test", "test"), "a");
            CallMainMenu();
        }

        private void DeleteAll()
        {
            Console.Clear();
            Console.WriteLine("Delete all");
            Console.ReadKey();
            CallMainMenu();
        }
    }
}
