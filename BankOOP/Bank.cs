using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
	internal class Bank
	{
		//attribútumok
		private List<BankSzamla> szamlak = new List<BankSzamla>();

		//új számla létrehozása
		public void SzamlaLetrehoz(string tulajdonosNev, int kezdoEgyenleg)
		{
			BankSzamla ujSzamla = new BankSzamla(tulajdonosNev, kezdoEgyenleg);
			szamlak.Add(ujSzamla);
            Console.WriteLine($"Új számla létrehozva! {ujSzamla.GetSzamlaAdatok()}");
        }

		//számla keresés
		public BankSzamla SzamlaKeres(string szamlaszam)
		{
			foreach (var szamla in szamlak)
			{
				if (szamla.SzamlaSzam == szamlaszam)
				{
					return szamla;
				}
			}
			return null;
		}

		public void OsszesSzamlaAdatok()
		{
			if (szamlak.Count == 0)
			{
				Console.WriteLine();
			}
			else
			{
                Console.WriteLine("Összes számla: 0");
				foreach (var szamla in szamlak)
				{
					Console.WriteLine(szamla.GetSzamlaAdatok());
				}
            }
        }
	}
}
