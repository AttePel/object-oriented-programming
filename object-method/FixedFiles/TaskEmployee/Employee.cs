using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEmployee
{
    class Employee
    {
		public string Name;
		public int Id;
		public string Position;
		public double Salary;


		public Employee(string name, int id, string position, double salary)
		{
			Name = name;
			Id = id;
			Position = position;
			Salary = salary;
		}

		public void PrintEmployeeInfo()
		{
			Console.WriteLine($"Työntekijän nimi: {Name}\n" +
		 $"Id: {Id}\n" +
		 $"Tehtävä: {Position}\n" +
		 $"Palkka: {Salary}\n");
		}
		
		public void CompareSalary(Employee employee)
		{
			if (Salary < employee.Salary)
			{
				Console.WriteLine($"{employee.Name}n palkka on suurempi kuin {Name}n palkka");
			}
			else
			{
				Console.WriteLine($"{Name}n palkka on suurempi kuin {employee.Name}n palkka");
			}
		}
    }
}
