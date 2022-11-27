using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Курсовая_работа
{
    public class Authorization
    {
        private List<Worker> Workers = new List<Worker>();

        public bool CheckWorker(string login, string password)
        {
            bool flag = false;
            
            byte[] Hash;
            UnicodeEncoding ue = new UnicodeEncoding();
            byte[] bytes = ue.GetBytes(password);
            SHA256 shHash = SHA256.Create();
            Hash = shHash.ComputeHash(bytes);

            foreach (Worker worker in Workers)
            {
                if (worker.credentials.Login == login && worker.credentials.Hash.SequenceEqual(Hash))
                {
                    flag = true;
                    ControlID.worker = worker;
                    break;
                }
            }
            return flag;
        }

        public Authorization()
        {
            if (File.Exists("WorkersData.json"))
            {
                Workers = JsonConvert.DeserializeObject<List<Worker>>(File.ReadAllText("WorkersData.json"));
            }
            else
            {
                throw new FileNotFoundException("Не удалось прочитать базу работников.");
            }
        }
    }
}
