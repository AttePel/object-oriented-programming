using System;
using System.Collections.Generic;
using System.Linq;

namespace BankApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("BankApp v.1.0");
			Bank bank = new Bank("Aten Pankki");

			List<Customer> customers = new List<Customer>();
			customers.Add(new Customer(bank.CreateAccount(), "Matti", "Massi"));
			customers.Add(new Customer(bank.CreateAccount(), "Pekka", "Hynä"));
			customers.Add(new Customer(bank.CreateAccount(), "Mikko", "Kyhny"));

			Random rnd = new Random();
			for (int i = 0; i < 2; i++)
			{
				bank.AddTransactionForCustomer(customers[rnd.Next(0, 3)].AccountNumber,
					new Transaction(rnd.Next(-3000, 5000),
					new DateTime(2017, rnd.Next(1, 13), rnd.Next(1, 28))));
			}

			//bank.AddTransactionForCustomer(customers[0].AccountNumber, new Transaction(1234, new DateTime(2018, 03, 23)));
			//bank.AddTransactionForCustomer(customers[1].AccountNumber, new Transaction(3245, new DateTime(2018, 03, 23)));
			//bank.AddTransactionForCustomer(customers[2].AccountNumber, new Transaction(2600, new DateTime(2018, 03, 23)));
			//bank.AddTransactionForCustomer(customers[0].AccountNumber, new Transaction(75, new DateTime(2018, 03, 27)));
			//bank.AddTransactionForCustomer(customers[1].AccountNumber, new Transaction(255, new DateTime(2018, 03, 23)));
			//bank.AddTransactionForCustomer(customers[2].AccountNumber, new Transaction(912, new DateTime(2018, 03, 26)));
			//bank.AddTransactionForCustomer(customers[1].AccountNumber, new Transaction(912, new DateTime(2018, 03, 26)));

			for (int i = 0; i < customers.Count; i++)
			{
				PrintBalance(bank, customers[i]);
			}

			//var endTime = DateTime.Today;
			var endTime = new DateTime(2017, 12, 31);
			var time = new TimeSpan(24 * 30 * 6, 0, 0);
			var startTime = new DateTime(2017, 01, 01);//endTime.Date - time;
			Console.WriteLine($"Tilipahatumat viimeisen vuoden ajalta: {startTime.ToShortDateString()}" +
				$"-{endTime.ToShortDateString()}");

			PrintTransactions(bank.GetTransactionsForCustomerForTimeSpan(customers[0].AccountNumber,
			startTime, endTime), customers[0]);
			PrintTransactions(bank.GetTransactionsForCustomerForTimeSpan(customers[0].AccountNumber,
			startTime, endTime), customers[1]);
			PrintTransactions(bank.GetTransactionsForCustomerForTimeSpan(customers[0].AccountNumber,
			startTime, endTime), customers[2]);


			Console.WriteLine("<Enter> lopettaa!");
			Console.ReadLine();
		}

		public static void PrintBalance(Bank bank, Customer customer)
		{
			var balance = bank.GetBalanceForCustomer(customer.AccountNumber);
			//Console.WriteLine("{0} - balance: {1}{2:0.00}",
			//  customer.ToString(), balance >= 0 ? "+" : "", balance);

			if (balance >= 0)
				Console.WriteLine($"{customer.ToString()} +{balance:C}");
			else
				Console.WriteLine($"{customer.ToString()} {balance:C}");
		}
		public static void PrintTransactions(List<Transaction> transactions, Customer customer)
		{
			Console.WriteLine($"Tilitapahtumat {customer.FirstName} {customer.LastName}:");

			for (int i = 0; i < transactions.Count(); i++)
			{
				//Console.WriteLine("{0}\t{1}{2:0.00}",
			//transactions[i].TimeStamp.ToShortDateString(),
				//transactions[i].Sum >= 0 ? "+" : "",
				//transactions[i].Sum);

				if (transactions[i].Sum >= 0)
					Console.WriteLine($"{transactions[i].TimeStamp.ToShortDateString()}\t" +
						$"+{transactions[i].Sum:F}");
				else
					Console.WriteLine($"{transactions[i].TimeStamp.ToShortDateString()}\t" +
						$"{transactions[i].Sum:F}");
			}
			Console.WriteLine("\n");
		}
	}
}