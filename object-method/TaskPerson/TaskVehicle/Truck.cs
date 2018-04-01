using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle
{
	class Truck : Car
	{
		protected double Load;
		protected double GasKg;

		public Truck(string type, string brand, int year, double price, double motorsize, string model, int doors, double load, double gaskg) : base(type, brand, year, price, motorsize, model, doors)
		{
			Load = load;
			GasKg = gaskg;
		}

		public string CalcCons()
		{
			double cons = Load / GasKg;
			return $"Kuorma-auto kuluttaa: {cons} litraa.";
		}
	}
}