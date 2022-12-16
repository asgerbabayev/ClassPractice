using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User : IAccount
    {
        private static int _id = 0;
        public int Id 
        {
            get => ++_id;
        }
        public string FullName { get; set; }
        public string Email { get; set; }

        private string _password;
        public string Password 
        {
            get => _password;
            set
            {
                if (!PasswordChecker(value))
                {
                    throw new Exception("Password duzgun teyin olunmuyub");
                }
                _password = value;
            }
        }

        public User( string email, string password)
        {
            Email = email;
            Password = password;
        }

        public bool PasswordChecker(string password)
        {
            if (password.Trim().Length <= 8) return false;
            if (password.All(letter => Char.IsLower(letter))) return false;
            if (password.All(letter => Char.IsUpper(letter))) return false;
            if (password.All(letter => Char.IsLetter(letter))) return false;

            return true;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}\nFullName: {FullName}\nEmail: {Email}");
        }

        public override string ToString()
        {
            return $"Id: {Id}\nFullName: {FullName}\nEmail: {Email}";
        }
    }
}
