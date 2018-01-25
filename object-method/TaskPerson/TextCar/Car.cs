using System;
using System.Collections.Generic;
using System.Text;

namespace TextCar
{
    class Car
    {
		//Car info

		public string Brand;
		public int Speed;

		//Constructor

		public Car()
		{
			Brand = null;
			Speed = 0;
		}

		//Methods

		public void AskData()
		{
			Console.WriteLine($"Syötä auton merkki ja nopeus.");
			Brand = Console.ReadLine();
			Speed = int.Parse(Console.ReadLine());
		}
		public void showCarInfo()
		{
			Console.WriteLine($"Auton merkki on: {Brand}\nAuton nopeus on: {Speed} km/h\n");
		}
		public void Accelerate()
		{
			Console.WriteLine("Anna luku, jolla auton nopeus kerrotaan");
			double speed1 = double.Parse(Console.ReadLine());

			if (speed1 < 1)
				Console.WriteLine($"Negatiivinen luku ei sallitu");
			else
			Console.WriteLine($"Auton nopeus nostettiin {speed1} kertaiseksi, uusi nopeus on {speed1 * Speed} km/h\n");

		}
		public void Brake()
		{
			double speed2 = Speed * 0.9;
			Console.WriteLine($"Autosi nopeutta vähennetään 10%, uusi nopeus on {speed2} km/h");
		}

    }
}
