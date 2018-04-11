using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Rajapinta.Repositories
{
    class Kauppa : IAsiakkaat, ITuotteet
    {
		public string Nimi;
		public string Liikevaihto;
		public List<Tuote> tuotteet;
		public List<Asiakas> asiakkaat;

		public Kauppa(string nimi, string liikevaihto)
		{
			Nimi = nimi;
			Liikevaihto = liikevaihto;
			List<Asiakas> asiakkaat = new List<Asiakas>();
			List<Tuote> tuotteet = new List<Tuote>();
		}

		public override string ToString()
		{
			return ($"\n{Nimi}\n{Liikevaihto:C}\n");
		}

		public void LisaaAsiakas(List<Asiakas> asiakas)
		{
			asiakkaat = asiakas;
		}
		public void TulostaAsiakkaat()
		{
			foreach (Asiakas a in asiakkaat)
			{
				Console.WriteLine($" {a.ToString()}");
				a.LaskeBonus();
			}
			Console.WriteLine($"Asiakkaita listalla:" +
				$" {asiakkaat.Count()}");
			Console.WriteLine(new string('-', 25));
		}

		public void LisaaTuote(List<Tuote> tuote)
		{
			tuotteet = tuote;
		}

		public void TulostaTuotteet()
		{
			foreach (Tuote t in tuotteet)
			{
				Console.WriteLine($"{t.ToString()}");
				t.LaskeYhteisArvo();
			}
			Console.WriteLine($"Tuotteita myynnissä:" +
				$" {tuotteet.Count()}");
			Console.WriteLine(new string('-', 25));
		}
	}
}