using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle
{
    abstract class Vehicle
	{
		public string Type;
		public string Brand;
		public int Year;
		public double Price;

		public Vehicle(string type, string brand, int year, double price)
		{
			Type = type;
			Brand = brand;
			Year = year;
			Price = price;
		}

		public virtual string PrintVehicleInfo()
		{
			return $"Ajoneuvon tiedot\nTyyppi: {Type}\nMerkki: {Brand}\nVuosimalli: {Year}\nHinta: {Price}\n";
		}
	}
}