using System;

namespace TaskEmployee
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Employee[] employees = new Employee[3];
			employees[0] = new Employee("Miko", 0003, "Ohjelmoija", 1200);
			employees[1] = new Employee("Juuso", 0004, "Ohjelmoija", 1100);
			employees[2] = new Employee("Olli", 0001, "Projektipäällikkö", 5215);
			for (int i = 0; i < 3; i++)
			{
				employees[i].PrintEmployeeInfo();
			}
			employees[1].CompareSalary(employees[2]);
			employees[0].CompareSalary(employees[1]);
			employees[2].CompareSalary(employees[01]);
			Console.ReadKey();
		}
	}
}