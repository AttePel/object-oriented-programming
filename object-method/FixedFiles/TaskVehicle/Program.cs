using System;

namespace TaskVehicle
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			Car carA = new Car("Henkilöauto", "Honda", 2017, 40.000, 1.6, "CR-V", 5);
			Car carB = new Car("Henkilöauto", "MB", 2010, 15000, 2.5, "AMG", 5);

			carA.PrintVehicleInfo();
			carB.PrintVehicleInfo();

			Console.WriteLine(carA.ToString());
			Console.WriteLine(carB.ToString());

			Console.WriteLine($"Onko Hondan moottori isompi kuin MV {carA.Equals(carB)}");

			Truck truckA = new Truck("Kuorma-auto", "Scania", 2000, 1000, 3.0, "Kuorma-auto", 2, 2500, 10);
			Console.WriteLine(truckA.ToString());
			Console.WriteLine(truckA.CalcCons());

			Console.ReadKey();
		}
	}
}