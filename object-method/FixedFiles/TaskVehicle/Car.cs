using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle
{
	class Car : Vehicle
	{
		protected double MotorSize;
		protected string Model;
		protected int Doors;

		public Car(string type, string brand, int year, double price, double motorsize, string model, int doors) : base(type, brand, year, price)
		{
			MotorSize = motorsize;
			Model = model;
			Doors = doors;
		}

		public override string PrintVehicleInfo()
		{
			return $"Ajoneuvon tiedot\nTyyppi: {Type}\nMerkki: {Brand}\nVuosimalli: {Year}\nHinta: {Price}\nMoottorin koko: {MotorSize}\nMalli: {Model}\nOvien lkm: {Doors}\n";
		}

		public override string ToString()
		{
			return PrintVehicleInfo();
		}

		public override bool Equals(object obj)
		{
			return (MotorSize > ((Car)obj).MotorSize);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
