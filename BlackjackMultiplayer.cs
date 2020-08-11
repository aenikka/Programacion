using System;

public class Program
{
	public static void Main()
	{
		Random aleatorio = new Random();
		int carta1 = 0, carta2 = 0, nuevacarta = 0, total = 0, jugadores = 1;
		int n = 0, maximo = 0, ganador = 0;
		string continuar = "n";

		Console.WriteLine("Ingrese un número de jugadores entre 2 y 5:");
		n = int.Parse(Console.ReadLine());

		while (n < 2 || n > 5)
		{
			Console.WriteLine("Error, mínimo 2 jugadores y máximo 5; ");
			n = int.Parse(Console.ReadLine());

		}

		while (jugadores <= n)
		{

		Console.WriteLine("Inicio de juego");

		Console.WriteLine("Bienvenido jugador " + jugadores);

		carta1 = aleatorio.Next(1, 10);
		carta2 = aleatorio.Next(1, 10);
		Console.WriteLine("Carta 1 = " + carta1);
		Console.WriteLine("Carta 2 = " + carta2);
		total = carta1 + carta2;
		Console.WriteLine("Total = " + total);

		Console.Write("Desea tomar otra carta? (s/n): ");
		continuar = Console.ReadLine();

		jugadores++;

			if (total > maximo && total <=21)
			{
				maximo = total;
				ganador = jugadores;
			}


			while (continuar == "s")
		{
			nuevacarta = aleatorio.Next(1, 11);
			Console.WriteLine("Carta = " + nuevacarta);
			total += nuevacarta;
			Console.WriteLine("Total = " + total);

			if (total >= 21)
			{
				Console.WriteLine("Eliminado");
				total = 0;
				continuar = "n";
			}

			else
			{
				Console.Write("Desea tomar otra carta? (s/n): ");
				continuar = Console.ReadLine();
			}

				if (total > maximo && total <= 21)
				{
					maximo = total;
					ganador = jugadores;
				}


			}

		}

		Console.WriteLine("El ganador fue " + ganador + " con " + maximo + " puntos");
		Console.WriteLine("Gracias por jugar.");
	}
}
