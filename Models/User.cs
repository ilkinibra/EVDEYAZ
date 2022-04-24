using System;
using System.Collections.Generic;
using System.Text;

namespace Task_10.Models
{
    interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
    internal class User : IAccount
    {
        private string _password;
        private static int _id;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get { return _password; }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                    return;

                }
                Console.WriteLine("Duzgun password daxil edin!");

            }
        }

        public User(string email, string password, string fullname)
        {
            _id++;
            Id = _id++;
            Email = email;
            Password = password;
            Fullname = fullname;
        }
        public bool PasswordChecker(string password)
        {
            bool HasUpper = false;
            bool HasLower = false;
            bool HasDigit = false;
            if (password.Length >= 8)
            {
                foreach (var item in password)
                {
                    if (char.IsUpper(item))
                    {
                        HasUpper = true;
                        continue;
                    }
                    if (char.IsLower(item))
                    {
                        HasLower = true;
                        continue;
                    }
                    if (char.IsDigit(item))
                    {
                        HasDigit = true;
                    }
                    bool resalt = HasUpper && HasDigit && HasLower;
                    return resalt;
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{ Id}\nFullname:{Fullname}\nEmail:{Email}");
        }
    }
}
