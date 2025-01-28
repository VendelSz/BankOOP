using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
	internal class BankSzamla
	{
		//Osztály attributumok
		//statikus változó lényege, hogy nem változik
		private static int kovetkezoSzamlaSzam = 1000;
		public string SzamlaSzam { get; private set; }
		public string TulajdonosNev { get; private set; }
		public int Egyenleg { get; private set; }

		//konstruktor
		//init -> kezdeti értéket adunk a változóknak
		public BankSzamla(string tulajdonosNev, int kezdoEgyenleg)
		{
			SzamlaSzam = $"ACC{kovetkezoSzamlaSzam++}";
			TulajdonosNev = tulajdonosNev;
			Egyenleg = kezdoEgyenleg;
		}

		//Befizet metódus
		public void Befizet(int osszeg)
		{
			if (osszeg > 0)
			{
				Egyenleg += osszeg;
				Console.WriteLine($"{osszeg} HUF befizetve a(z) {SzamlaSzam} számlára");
			} else
			{
                Console.WriteLine("Hibás összeg, nem lehet negatív vagy nulla.");
            }
		}

		//Kifizet metódus
		public void Kifizet(int osszeg)
		{
			if (osszeg > 0 && osszeg <= Egyenleg)
			{
				Egyenleg -= osszeg;
                Console.WriteLine($"{osszeg} HUF kifizetve a(z) {SzamlaSzam} számláról");
			} else
			{
				Console.WriteLine("Hibás összeg, vagy nincs elég pénz a számlán.");
			}
		}

		//számla adatok lekérdezése
		public string GetSzamlaAdatok()
		{
			return $"Számlaszám: {SzamlaSzam}, Tulajdonos: {TulajdonosNev}, Egyenleg: {Egyenleg}HUF.";
		}
	}
}
