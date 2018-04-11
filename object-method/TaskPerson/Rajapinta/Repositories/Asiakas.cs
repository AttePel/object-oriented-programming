using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Rajapinta.Repositories
{
    class Asiakas : IAsiakas
    {
		public string Name;
		public double Purchase;

		public Asiakas(string name, double purchase)
		{
			Name = name;
			Purchase = purchase;
		}

		public override string ToString()
		{
			return ($"\nAsiakas: {Name}" +
					$"\nOstosten kuitti: {Purchase:C}");
		}

			public void HaeAsiakas()
		{
			string UusiAsiakas = Name;
			if (UusiAsiakas == Name)
			{
				Console.WriteLine($"{Name}");
			}
			else
			{
				Console.WriteLine($"{null}");
			}
		}

		public void LaskeBonus()
		{
			double Total;
			if (Purchase <= 1000)
			{
				Total = Purchase * 0.02;
				Console.WriteLine($"Bonusta 2%: {Total:C}\n");
				Console.WriteLine(new string('-', 25));
			}
			else if (Purchase > 1000 && Purchase < 200)
			{
				Total = Purchase * 0.03;
				Console.WriteLine($"Bonusta 3%: {Total:C}\n");
				Console.WriteLine(new string('-', 25));
			}
			else
			{
				Total = Purchase * 0.05;
				Console.WriteLine($"Bonusta 5%: {Total:C}\n");
				Console.WriteLine(new string('-', 25));
			}
		}
	}
}
