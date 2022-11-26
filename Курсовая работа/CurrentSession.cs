using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
			Console.WriteLine(textJson);
        }

		private void LoadChanges<T>(out T obj, string filename)
		{
			if (File.Exists(filename))
			{
				obj = JsonConvert.DeserializeObject<T>(File.ReadAllText(filename));
			}
			else
			{
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
			bool flag = true;
			foreach (Applicant i in Applicants)
			{
				if (i.ID == applicant.ID)
				{
					flag = false;
					break;
				}
			}

			if (flag)
			{
				Applicants.Add(applicant);
				SaveChanges(Applicants, "ApplicantsData.json");
			}  
			else
				throw new ArgumentException("Не удалось добавить абитуриента, так как данное ID уже используется.");
		}

		public void AddWorker(Worker worker)
		{
			bool flag = true;
			foreach (Worker i in Workers)
			{
				if (i.ID == worker.ID)
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

		public bool DeleteWorker(int ID)
		{
			bool flag = false;
			if (CurrentWorker.Status == Status.Admin)
			{
				if (ID != CurrentWorker.ID)
				{
					for (int i = 0; i < Workers.Count; i++)
					{
						if (Workers[i].ID == ID)
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

		public List<Applicant> FindApplicants(int ID)
		{
			throw new NotImplementedException();
		}

		public List<Applicant> FindApplicants(string name, string surname)
		{
			throw new NotImplementedException();
		}

		public List<Applicant> FindApplicants(FieldOfStudy fieldOfStudy)
		{
			throw new NotImplementedException();
		}

        public CurrentSession(Worker _currentWorker)
        {
            CurrentWorker = _currentWorker;
        }

        //public CurrentSession(List<Worker> _workers, List<Applicant> _applicants, Worker _currentWorker)
		//{
		//	Workers = _workers;
		//	Applicants = _applicants;
		//	CurrentWorker = _currentWorker;
		//}
	}
}
