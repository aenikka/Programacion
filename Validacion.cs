using System;

public class Program
{
	public static void Main()
	{
		Random aleatorio = new Random();
		int a = 0, b = 0, sumacorrecta = 0, intentos = 3, respuesta = 0;

		while (intentos > 0)
		{
			a = aleatorio.Next(0, 11);
			b = aleatorio.Next(0, 11);
			sumacorrecta = a + b;

			Console.WriteLine("Sume " + a + "+" + b);
			respuesta = int.Parse(Console.ReadLine());

			if (respuesta == sumacorrecta)
			{
				Console.WriteLine("Puede continuar");
				break;

			}

			else
			{
				intentos--;
				Console.WriteLine("Intente nuevamente");

			}


		}


		if (intentos == 0)
		{
			Console.WriteLine("Validación incorrecta, no puede continuar.");
		}

	}
}
