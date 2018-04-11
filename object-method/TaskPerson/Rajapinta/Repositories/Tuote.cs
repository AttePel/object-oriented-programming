using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Rajapinta.Repositories
{
    class Tuote : ITuote
    {
		public string Name;
		public double Price;
		public double Count;

		public Tuote(string name, double price, double count)
		{
			Name = name;
			Price = price;
			Count = count;
		}

		public override string ToString()
		{
			return ($"Tuotteen nimi: {Name}\n" +
					 $"Hinta: {Price}\n" +
					 $"Lukumäärä: {Count}\n");
		}

		public void HaeTuote()
		{
			string NewName = Name;
			if (NewName == Name)
			{
				Console.WriteLine($"{Name}");
			}
			else
			{
				Console.WriteLine($"{null}");
			}
		}

		public void LaskeYhteisArvo()
		{
			double Total = Price * Count;
			Console.WriteLine($"Yhteisarvo on: {Total:C}\n");
			Console.WriteLine(new string('-', 25));
		}
	}
}
