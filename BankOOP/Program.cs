﻿namespace BankOOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Bank bank = new Bank();
			bool fut = true;

			while(fut)
			{
                Console.WriteLine("\n1. Új számla létrehozása");
				Console.WriteLine("\n2. Befizetés");
				Console.WriteLine("\n3. Kifizetés");
				Console.WriteLine("\n4. Egy számla adatai");
				Console.WriteLine("\n5. Összes számla listázása");
				Console.WriteLine("\n6. Kilépés");
				Console.Write("Válassz egy lehetőséget");
				int valasztas = Convert.ToInt32(Console.ReadLine());

				switch(valasztas)
				{
					case 1:
                        Console.Write("Add meg a tulajdonos nevét: ");
						string nev = Console.ReadLine();
                        Console.Write("Add meg a kezdő egyenleget: ");
						int kezdoEgyenleg = Convert.ToInt32(Console.ReadLine());
						bank.SzamlaLetrehoz(nev,kezdoEgyenleg);
						break;
                }
			}
			Console.ReadLine();
		}
	}
}
