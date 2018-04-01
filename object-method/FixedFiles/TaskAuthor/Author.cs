using System;
using System.Collections.Generic;
using System.Text;
using Literature;

namespace TaskAuthor
{
	class Author
	{
		public string Name;
		public string Birthday;
		public string Book;

		public Author(string name, string birthday, string book)
		{
			Name = name;
			Birthday = birthday;
			Book = book;
		}

		public void PrintInfo()
		{
			Console.WriteLine($"Kirjailijan nimi on: {Name}");
			Console.WriteLine($"Kirjailija on syntynyt: {Birthday}");
			Console.WriteLine($"Kirjailija on kirjoittanut teoksen: {Book}");
		}
	}
}