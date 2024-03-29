﻿using Newtonsoft.Json;
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
    public class Authorization : IAuthorization
    {
        private List<Worker> Workers = new List<Worker>();

        // Проверка наличия работника в базе
        public bool CheckWorker(string login, string password, out Worker a)
        {
            bool flag = false;
            a = null;

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
                    a = worker;
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
                throw new FileNotFoundException("'WorkersData.json' не существует.");
            }
        }
    }
}
