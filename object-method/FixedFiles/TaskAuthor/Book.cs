using System;
using System.Collections.Generic;
using System.Text;

namespace Literature
{
	class Book
	{
		public string Name;
		private string _Author;
		public string Publisher;
		public double Price;
		public string Theme;
		private double newPrice;
		static string ChangeTheme;

		public Book()
		{
			Name = "Unknown";
			_Author = "Unknown";
			Publisher = "Unknown";
			Price = 0;
			Theme = "Unknown";
		}

		public Book(string Name, string Author, string Publisher, double Price, string Theme)
		{
			this.Name = Name;
			this._Author = Author;
			this.Publisher = Publisher;
			this.Price = Price;
			this.Theme = Theme;
			NewPrice = Price;
		}

		public Book(Book book)
		{
			this.Name = book.Name;
			this._Author = book.Author;
			this.Publisher = book.Publisher;
			this.Price = book.Price;
			this.Theme = book.Theme;
		}

		public void SearchBook(Book book)
		{
			if (this.Name.Equals(book.Name))
				Console.WriteLine("Kirja löytyi");
			else
			{
				Console.WriteLine($"Kirjaa {book.Name}, ei löytynyt");
			}
			Console.WriteLine($"{book.Name}\n" +
			$"{book.Author}\n" +
			$"{book.Publisher}\n" +
			$"{book.Price}\n" +
			$"{book.Theme}\n");
			if (book.Price > 30)
				Console.WriteLine($"Kirjan alennettu hinta on: {book.NewPrice:C}");
		}	
		public void SearchBook(string name)
		{
			if (Name.Equals(name))
				PrintBook();

			else
			{
				Console.WriteLine($"Kirjaa {Name}, ei löytynyt");
				PrintBook();
			}
		}

		public void PrintBook()
		{
			Console.WriteLine($"{Name}");
			Console.WriteLine($"{Author}");
			Console.WriteLine($"{Publisher}");
			Console.WriteLine($"{Price}");
			Console.WriteLine($"{Theme}");
		}

		public double NewPrice
		{
			get
			{
				return newPrice;
			}
			set
			{
				if (value > 30)
				{
					newPrice = value * 0.9;
				}
			}
		}

		public string Author
		{
			get => _Author;
		}

		public static void ThemeChange()
		{
			Console.WriteLine(ChangeTheme);
		}
	}
}