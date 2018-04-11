using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Rajapinta.Repositories;

namespace Rajapinta

{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Tervetuloa El Giganteniin!\n");
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			List<Tuote> tuotteet = new List<Tuote>();

			Tuote tuote1 = new Tuote("Tietokone", 500, 50);
			Tuote tuote2 = new Tuote("Näppäimistö", 70, 65);
			Tuote tuote3 = new Tuote("Hiiri", 35, 75);

			tuotteet.Add(tuote1);
			tuotteet.Add(tuote2);
			tuotteet.Add(tuote3);

			tuotteet[0].HaeTuote();
			tuotteet[0].LaskeYhteisArvo();

			tuotteet[1].HaeTuote();
			tuotteet[1].LaskeYhteisArvo();
			tuotteet[2].HaeTuote();
			tuotteet[2].LaskeYhteisArvo();

			List<Asiakas> asiakkaat = new List<Asiakas> ();
			Asiakas asiakas1 = new Asiakas("Keijo Kyhny", 400);
			Asiakas asiakas2 = new Asiakas("Pete Kauppinen", 4000);
			Asiakas asiakas3 = new Asiakas("Upi Behm", 1000);

			asiakkaat.Add(asiakas1);
			asiakkaat.Add(asiakas2);
			asiakkaat.Add(asiakas3);

			asiakkaat[0].HaeAsiakas();
			asiakkaat[0].LaskeBonus();
			asiakkaat[1].HaeAsiakas();
			asiakkaat[1].LaskeBonus();
			asiakkaat[2].HaeAsiakas();
			asiakkaat[2].LaskeBonus();

			Kauppa kauppa = new Kauppa("El Giganten", "500 000 000");
			kauppa.LisaaAsiakas(asiakkaat);
			kauppa.LisaaTuote(tuotteet);
			kauppa.TulostaAsiakkaat();
			kauppa.TulostaTuotteet();
			Console.ReadKey();
		}
	}
}