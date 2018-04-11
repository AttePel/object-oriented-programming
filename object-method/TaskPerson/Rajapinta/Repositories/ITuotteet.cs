using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Rajapinta.Repositories
{
    interface ITuotteet
    {
		void LisaaTuote(List <Tuote> tuote);
		void TulostaTuotteet();
	}
}
