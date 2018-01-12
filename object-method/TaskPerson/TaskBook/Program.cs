using System;

namespace TaskBook
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Book newBook = new Book("Pieni Pumppu", "Mikko Lonka", 2241, 40.99 );
			newBook.PrintBookInfo();

			Book newBook2 = new Book("Koodiluola", "Make Moppi", 2492, 29.99);
			newBook2.PrintBookInfo();

			Book newBook3 = new Book("Fortnite Tips and Tricks", "Quartze_", 1234, 50.99);
			newBook3.PrintBookInfo();

			Console.WriteLine($"{newBook2.CompareBook(newBook)}");
			Console.WriteLine($"{newBook3.CompareBook(newBook)}");


			Console.ReadKey();

		}
	}
}
