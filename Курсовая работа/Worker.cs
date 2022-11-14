using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

// hash https://learn.microsoft.com/ru-ru/dotnet/standard/security/ensuring-data-integrity-with-hash-codes
namespace Курсовая_работа
{
    public enum Status : byte
    {
        [Description("Worker can add, delete and find applicants")]
        Worker = 0,
        [Description("Admin can add, delete workers, add, delete and find applicants")]
        Admin = 1
    };
    public class Worker : Human
    {
        public string login { get; set; }
        public string password { get; set; }
        public Status Status { get; set; }
        private byte[] Hash;

        private Regex hasNumber = new Regex(@"[0-9]+");
        private Regex hasUpperChar = new Regex(@"[A-Z]+");
        private Regex hasMinimum6Chars = new Regex(@".{6,}");

        private void HashPassword()
        {
            UnicodeEncoding ue = new UnicodeEncoding();
            byte[] messageBytes = ue.GetBytes(password);
            SHA256 shHash = SHA256.Create();
            Hash = shHash.ComputeHash(messageBytes);
            //foreach (byte b in Hash) Console.Write("{0} ", b);
        }
        private bool ValidatePassword(string password)
        {
            bool flag = false;
            if (password != null)
                flag = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password)
                    && hasMinimum6Chars.IsMatch(password);
            return flag;
        }

        public string Login
        {
            get { return login; }
            set
            {
                if (value.Length < 6)
                    throw new ArgumentException("Длина логина должна быть не менее 6 символов");
                login = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (!ValidatePassword(value))
                    throw new ArgumentException("Пароль должен быть длиной не менее 6 символов, обязательно содержать хотя бы одну цифру и заглавную латинскую букву");
                password = value;
                HashPassword();
            }
        }
        
        
        public Worker(string _name, string _surname, string _middleName, DateTime _dateOfBirth, string _login, string _password, Status _status) : base (_name, _surname, _middleName, _dateOfBirth)
        {
            Login = _login;
            Password = _password;
            Status = _status;
        }
    }
}
