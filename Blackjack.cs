using System;

public class Program
{
	public static void Main()
	{
		Random aleatorio = new Random();
		int carta1 = 0, carta2 = 0, nuevacarta = 0, total = 0;
		string continuar = "n";


		carta1 = aleatorio.Next(1, 10);
		carta2 = aleatorio.Next(1, 10);
		Console.WriteLine("Carta 1 = " + carta1);
		Console.WriteLine("Carta 2 = " + carta2);
		total = carta1 + carta2;
		Console.WriteLine("Total = " + total);

		Console.Write("Desea tomar otra carta? (s/n): ");
		continuar = Console.ReadLine();


		while (continuar == "s")
		{
			nuevacarta = aleatorio.Next(1, 11);
			Console.WriteLine("Carta = " + nuevacarta);
			total += nuevacarta;
			Console.WriteLine("Total = " + total);

			if (total >= 21)
			{
				Console.WriteLine("Eliminado");
				continuar = "n";
			}

			else { 
			Console.Write("Desea tomar otra carta? (s/n): ");
			continuar = Console.ReadLine();
		}
		}

		Console.WriteLine("Su total fue " + total + " puntos");
		Console.WriteLine("Gracias por jugar.");
	}
}