using System;

public class Program
{
	public static void Main()
	{
		Random aleatorio = new Random();
		int dado = 0, total = 0, vidas = 3, turnos = 0, dado2 = 0;
		string continuar = "s";

		while (continuar == "s")
		{

			turnos++;

			if (turnos != 0 && turnos % 3 == 0)
			{
				dado = aleatorio.Next(0, 7);
				Console.WriteLine("Dado = " + dado);
				dado2 = aleatorio.Next(0, 7);
				Console.WriteLine("Dado 2 = " + dado2);

				if ((dado == dado2) && vidas < 3)

				{
					vidas++;
				}

			}

			else
			{

				dado = aleatorio.Next(0, 7);
				dado2 = 0;
				Console.WriteLine("Dado = " + dado);
			}


			total += dado + dado2;
			Console.WriteLine("Total = " + total);

			if (turnos != 0 && turnos % 2 == 0)
			{
				vidas--;
			}

			Console.WriteLine("Vidas = " + vidas);

			if (vidas == 0)
			{
				Console.WriteLine("Has perdido. Fin del juego.");
				break;
			}

			else if (total > 100)
			{
				Console.WriteLine("Has ganado. Fin del juego.");
				break;
			}

			else
			{
				Console.Write("Desea tirar de nuevo? (s/n): ");
				continuar = Console.ReadLine();
			}


		}

		Console.WriteLine("Su total fue " + total + " puntos");
		Console.WriteLine("Gracias por jugar.");
	}
}
