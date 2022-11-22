using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class Credentials
    {
        private string login;
        private string password;
        public byte[] Hash { get; private set; }

        private Regex hasNumber = new Regex(@"[0-9]+");
        private Regex hasUpperChar = new Regex(@"[A-Z]+");
        private Regex hasMinimum6Chars = new Regex(@".{6,}");

        [Description("Сравнивает хэш паролей")]
        internal static bool CompareHashes(byte[] hash1, byte[] hash2)
        {
            return hash1.SequenceEqual(hash2);
        }
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
                    throw new ArgumentException("Длина логина должна быть не менее 6 символов.");
                login = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (!ValidatePassword(value))
                    throw new ArgumentException("Пароль должен быть длиной не менее 6 символов, обязательно содержать хотя бы одну цифру и заглавную латинскую букву.");
                password = value;
                HashPassword();
            }
        }
        public Credentials(string _login, string _password)
        {
            Login = _login;
            Password = _password;
        }
    }
}
