using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Security.Policy;
using System.Windows.Forms;

namespace Курсовая_работа
{
	public class CurrentSession : ICurrentSession
	{
		public List<Applicant> Applicants = new List<Applicant>();
		public List<Worker> Workers = new List<Worker>();
		public Worker CurrentWorker;

        private void SaveChanges<T>(T obj, string filename)
        {
            var textJson = JsonConvert.SerializeObject(obj);
			File.WriteAllText(filename, textJson);
        }

		private void LoadChanges<T>(out T obj, string filename)
		{
			if (File.Exists(filename))
			{
				obj = JsonConvert.DeserializeObject<T>(File.ReadAllText(filename));
			}
			else
			{
				MessageBox.Show($"Не удалось найти '{filename }'!", "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                throw new FileNotFoundException($"'{ filename }' не существует.");
			}
		}

		public void Load()
		{
			LoadChanges(out Applicants, "ApplicantsData.json");
			LoadChanges(out Workers, "WorkersData.json");
		}

        public void AddApplicant(Applicant applicant)
		{
			foreach (Applicant i in Applicants)
			{
				if (i.ID == applicant.ID)
				{
                    DeleteApplicant(i.ID);
					break;
				}
			}

			Applicants.Add(applicant);
			SaveChanges(Applicants, "ApplicantsData.json");
		}

		public void AddWorker(Worker worker)
		{
			bool flag = true;
			foreach (Worker i in Workers)
			{
				if (worker.credentials.Login == i.credentials.Login ||
					worker.credentials.Hash.SequenceEqual(i.credentials.Hash))
				{
					flag = false;
					break;
				}
			}

			if (flag)
			{
				Workers.Add(worker);
				SaveChanges(Workers, "WorkersData.json");
			}
			else
				throw new ArgumentException("Не удалось добавить работника, так как данное ID уже используется.");
		}

		public bool DeleteApplicant(int ID)
		{
			bool flag = false;
			if (CurrentWorker.Status == Status.Admin)
			{
				for (int i = 0; i < Applicants.Count; i++)
				{
					if (Applicants[i].ID == ID)
					{
						flag = Applicants.Remove(Applicants[i]);
					}
				}
			}
			else
			{
				throw new ArgumentException("У вас недостаточно прав для выполнения данного действия.");
			}
			if (flag) SaveChanges(Applicants, "ApplicantsData.json");
			return flag;
		}

		public bool DeleteWorker(Worker worker)
		{
			bool flag = false;
			if (CurrentWorker.Status == Status.Admin)
			{
				if (!worker.Equals(CurrentWorker))
				{
					for (int i = 0; i < Workers.Count; i++)
					{
						if (Workers[i].Equals(worker))
						{
							flag = Workers.Remove(Workers[i]);
						}
					}
				}
				else
				{
					throw new ArgumentException("Нельзя удалить текущего работника.");
				}
			}
			else
			{
				throw new ArgumentException("У вас недостаточно прав для выполнения данного действия.");
			}
			if (flag) SaveChanges(Workers, "WorkersData.json");
			return flag;
		}

		public Applicant GetApplicant(int ID)
		{
			Applicant applicant = null;
            foreach (Applicant i in Applicants)
            {
                if (i.ID == ID)
                {
                    applicant = i;
                    break;
                }
            }
			return applicant;
        }

        public CurrentSession(Worker _currentWorker)
        {
            CurrentWorker = _currentWorker;
        }
	}
}
