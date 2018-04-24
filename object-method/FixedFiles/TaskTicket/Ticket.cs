using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTicket
{
	class Ticket
	{
		public int Age;
		public double Member;
		public double Soldier;
		public double Student;
		public double Price;

		public Ticket()
		{
			Age = 0;
			Price = 16;
		}
		public Ticket(int age, double member, double soldier, double student, double price)
		{
			Age = age;
			Member = member;
			Soldier = soldier;
			Student = student;
			Price = price;
		}

		public void AskPersonInfo()
		{
			Console.WriteLine("Ohjelma laskee lipun hinnan");
			Console.WriteLine($"Syötä ikäsi");
			string userInputAge = Console.ReadLine();
			Age = int.Parse(userInputAge);
			Console.WriteLine($"Oletko MTK:n jäsen? Syötä 1=Kyllä tai 0=Ei");
			string userInputMTK = Console.ReadLine();
			Member = double.Parse(userInputMTK);
			Console.WriteLine($"Oletko varusmies? Syötä 1=Kyllä tai 0=Ei");
			string userInputSoldier = Console.ReadLine();
			Soldier = double.Parse(userInputSoldier);
			Console.WriteLine($"Oletko opiskelija? Syötä 1=Kyllä tai 0=Ei");
			string userInputStudent = Console.ReadLine();
			Student = double.Parse(userInputStudent);
		}
		public void ShowPersonInfo()
		{
			Console.WriteLine($"Ikä: {Age}");
		}

		public void Discount()
		{
			if (Age < 7)
				Console.WriteLine($"Lipun hinta: {Price * 0} euroa.");
			if (Age > 65)
				Console.WriteLine($"Lipun hinta: {Price * 0.50} euroa.");
			if (Age > 7 && Age <= 15)
				Console.WriteLine($"Lipun hinta: {Price * 0.50} euroa.");
			if (Age > 15 && Age < 65)
			{
				if (Soldier == 1)
					Console.WriteLine($"Lippusi alennettu hinta on: {Price * 0.5} euroa.");
				else
				{
					if (Member == 1)
					{
						Price = Price * 0.85;
					}
					if (Student == 1)
					{
						Price = Price * 0.55;
					}
					Console.WriteLine($"Alennettu hinta on {Price} euroa.");
				}
			}
		}
	}
}