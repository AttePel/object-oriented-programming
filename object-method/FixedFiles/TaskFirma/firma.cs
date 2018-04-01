using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFirma
{
	class Firma
	{
		//Fields 
		public string Title;
		public string Address;
		public string Phone;
		public double Income;
		public double Expense;

		//constructor

		public Firma(string title, string address, string phone, double income, double expense)
		{
			Title = title;
			Address = address;
			Phone = phone;
			Income = income;
			Expense = expense;
		}

		public Firma()
		{
			Title = "Unknown";
			Address = "Unknown";
			Phone = "Unknown";
			Income = 0;
			Expense = 0;
		}

		public Firma(Firma company)
		{
			Title = company.Title;
			Address = company.Address;
			Phone = company.Phone;
			Income = company.Income;
			Expense = company.Expense;
		}

		public void AskData()
		{
			Console.WriteLine($"Syötä yrityksesi nimi, osoite, puhelinnumero, tulot ja menot");
			Title = Console.ReadLine();
			Address = Console.ReadLine();
			Phone = Console.ReadLine();
			Income = double.Parse(Console.ReadLine());
			Expense = double.Parse(Console.ReadLine());
		}

		public void ShowCompanyInfo()
		{
			Console.WriteLine($"Yrityksen nimi: {Title}\n" +
                $"Osoite: {Address}\n" +
                $"Puhelinnumero: {Phone}\n" +
                $"Tulot: {Income}\n" +
                $"Menot: {Expense}");
		}

	    public void CompanyProfitCalculate()
		{
			double profit = (Income - Expense) / Expense * 100;
			Console.WriteLine($"Yrityksen voittoprosentti: {profit:f2}");
			if (profit < 100)
			{
				Console.WriteLine($"Yrityksen tulos on kehno");
			}
			if (profit > 100 && profit <= 300)
			{
				Console.WriteLine($"Yrityksen tulos on tyydyttävä");
			}
			if (profit > 300)
			{
				Console.WriteLine($"Yrityksen tulos on kiitettävä");
			}
		}
	}
	
}
