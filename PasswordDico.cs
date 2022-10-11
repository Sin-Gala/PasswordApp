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
            Console.WriteLine("Add " + datas.website + " - " + datas.password);
            Console.ReadKey();
        }

        public void RemoveDatas(PasswordDatas datas)
        {
            Console.WriteLine("Remove");
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
