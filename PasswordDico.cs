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
            if (passwordDatas.Count == 0)
            {
                Console.WriteLine("No Websites Saved");
                Console.ReadKey();
                return;
            }

            for (int i = passwordDatas.Count -1; i >= 0; i--)
            {
                if (passwordDatas[i].website != website)
                    continue;

                passwordDatas.RemoveAt(i);
                Console.WriteLine("Remove " + website);
                break;
            }

            Console.ReadKey();
        }

        public void EditDatas(PasswordDatas datas, string newPassword)
        {
            Console.WriteLine("Edit");
            Console.ReadKey();
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
