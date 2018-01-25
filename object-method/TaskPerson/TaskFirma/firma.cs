using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFirma
{
    class Firma
    {
		//Fields 
		public string Title;
		public string  Address;
		public int Phone;
		public double Income;
		public double Expense;

		public Firma(string title, string address, int phone, double income, double expense);

    }
	
	//Method 
	public void AskData()
	{
		Console.WriteLine ($"")
		Title = Console.ReadLine();
		Address = Console.ReadLine();


	}
}
