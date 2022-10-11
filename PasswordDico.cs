using System;
using System.Collections.Generic;

namespace PasswordApp
{
    public class PasswordDico
    {
        public List<PasswordDatas> passwordDatas = new List<PasswordDatas>();

        public void AddDatas(PasswordDatas datas)
        {
            if (passwordDatas.Count == 0)
            {
                passwordDatas.Add(datas);
                // Save dico
                Console.WriteLine("Add " + datas.website + " - " + datas.password);
                Console.ReadKey();
                return;
            }

            foreach (PasswordDatas passDatas in passwordDatas)
            {
                if (passDatas.website != datas.website)
                    return;

                // Ask user if it's the same account
                // Ask user if they want to change the name
                // If not -> Just add a number at the end of the name
                Console.WriteLine("Same Website name: " + passDatas.website);
                Console.ReadKey();
                return;
            }

            passwordDatas.Add(datas);
            // Save dico
            Console.WriteLine("Add " + datas.website + " - " + datas.password);
            Console.ReadKey();
        }

        public void RemoveDatas(string website)
        {
            int index = CheckWebsiteExist(website);

            if (index == -1)
            {
                Console.WriteLine("No Websites Saved");
                Console.ReadKey();
                return;
            }

            passwordDatas.RemoveAt(index);
            Console.WriteLine("Remove " + website);

            Console.ReadKey();
        }

        public void EditDatas(string website, string newPassword)
        {
            int index = CheckWebsiteExist(website);

            if (index == -1)
            {
                // Move this to User Interaction
                Console.WriteLine("This website isn't saved yet. " +
                    "\nDo you wish to add it? y/n");

                switch (Console.ReadLine())
                {
                    case "y":
                        AddDatas(new PasswordDatas(website, newPassword));
                        return;
                    case "n":
                    default:
                        break;
                }

                Console.ReadKey();
                return;
            }

            passwordDatas[index].SetPassword(newPassword);
            Console.WriteLine("Edited " + website + " - " + newPassword);

            Console.ReadKey();
        }

        private int CheckWebsiteExist(string name)
        {
            if (passwordDatas.Count == 0)
                return -1;

            for (int i = 0; i < passwordDatas.Count; i++)
            {
                if (passwordDatas[i].website != name)
                    continue;

                return i;
            }

            return -1;
        }
    }

    public class PasswordDatas
    {
        public PasswordDatas(string website, string password = null)
        {
            this.website = website;
            this.password = password;
        }

        public string website { get; init; }
        public string password { get; private set; }

        public void SetPassword(string password)
            => this.password = password;
    }
}
