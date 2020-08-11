using System;

public class Program
{
	public static void Main()
	{
		Random aleatorio = new Random();
		int dado = 0, total = 0, dadopasado = 0, dadoespecial = 2, vidas = 3, unos = 0;
		string continuar = "s", especial = "n";


		while (continuar == "s")
		{


			dadopasado = dado;


			if (dadoespecial != 0)
			{
				Console.WriteLine("Desea tirar un dado especial? (s/n)");
				especial = Console.ReadLine();

				if (especial == "s")
				{
					dado = aleatorio.Next(0, 13);
					dadoespecial--;
				}

				else
				{
					dado = aleatorio.Next(0, 7);
				}
			}

			else
			{
				dado = aleatorio.Next(0, 7);
			}

			if (dado == 1)
			{
				unos++;

				if (unos % 2 == 0 && unos != 0)
				{
					vidas--;
					total = total - 10;
				}

			}

			Console.WriteLine("Dado = " + dado);
			total += dado;
			Console.WriteLine("Total = " + total);


			if ((dadopasado == 6 && dado == 6) && vidas < 3)

			{
				vidas++;
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
