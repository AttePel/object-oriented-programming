﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Rajapinta.Repositories
{
    interface IAsiakkaat
    {
		void LisaaAsiakas(List<Asiakas> asiakas);
		void TulostaAsiakkaat();
	}
}
