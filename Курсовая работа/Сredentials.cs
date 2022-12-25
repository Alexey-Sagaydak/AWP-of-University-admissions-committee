using Newtonsoft.Json;
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
    public class Credentials : ICredentials
    {
        private string login;
        private string password;

        [JsonProperty("password_hash")]
        public byte[] Hash { get; set; }

        // Регулярные выражения, проверяющие пароль на безопасность
        private Regex hasNumber = new Regex(@"[0-9]+");
        private Regex hasUpperChar = new Regex(@"[A-Z]+");
        private Regex hasMinimum6Chars = new Regex(@".{6,}");

        // Метод, превращающий пароль в хэш
        private void HashPassword()
        {
            UnicodeEncoding ue = new UnicodeEncoding();
            byte[] messageBytes = ue.GetBytes(password);
            SHA256 shHash = SHA256.Create();
            Hash = shHash.ComputeHash(messageBytes);
            //foreach (byte b in Hash) Console.Write("{0} ", b);
            //Console.WriteLine("\n");
        }

        // Проверка пароля на безопасность
        private bool ValidatePassword(string password)
        {
            bool flag = false;
            if (password != null)
                flag = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password)
                    && hasMinimum6Chars.IsMatch(password);
            return flag;
        }

        [JsonProperty("login")]
        public string Login
        {
            get { return login; }
            set
            {
                if (value != null && value.Length < 6)
                    throw new ArgumentException("Длина логина должна быть не менее 6 символов.");
                login = value;
            }
        }

        [JsonProperty("password")]
        public string Password
        {
            get { return password; }
            set
            {
                if (value != null && !ValidatePassword(value))
                    throw new ArgumentException("Пароль должен быть длиной не менее 6 символов, обязательно содержать хотя бы одну цифру и заглавную латинскую букву.");
                password = value;
                if (value != null) HashPassword();
                password = null;
            }
        }

        public Credentials(string _login, string _password)
        {
            Login = _login;
            Password = _password;
        }
    }
}
