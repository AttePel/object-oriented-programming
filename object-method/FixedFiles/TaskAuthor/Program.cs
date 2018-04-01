using System;
using Literature;

namespace TaskAuthor
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Yli 30€ kirjoista 10% alennus.");

			Author newAuthor1 = new Author("Juuso Julli", "15.09.1996", "Laiskuri");
			newAuthor1.PrintInfo();
			Book newBook1 = new Book("Koodi", "Juuso Julli", "Wsoy", 10.99, "Oppaat");
			Console.WriteLine($"Uusi teema: {newBook1.Author}");
			newBook1.SearchBook(newBook1);
			Book.ThemeChange();

			Author newAuthor2 = new Author("Mikko Makke", "21.01.1989", "Ek");
			newAuthor2.PrintInfo();
			Book newBook2 = new Book("Kauppa", "Mikko Makke", "Wsoy", 45.15, "Matkakirja");
			newBook1.SearchBook(newBook2);

			Author newAuthor3 = new Author("Kalle Kohonen", "01.01.2001", "Jamaican Burger");
			newAuthor3.PrintInfo();
			Book newBook3 = new Book("Krimille", "Kalle Kohonen", "Epic", 65.99, "Seikkailu");
			newBook1.SearchBook(newBook3);
			Console.ReadKey();
		}
	}
}