using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Ingrese su estatura en metros: ");
		double estatura = double.Parse(Console.ReadLine());

		Console.WriteLine("Ingrese su peso en kilos: ");
		double peso = double.Parse(Console.ReadLine());


		double imc = (peso / (estatura * estatura));

		if (imc < 18.5)
		{
			Console.WriteLine("Está en un peso bajo");
		}

		else if (18.5 <= imc && imc <= 24.9)
		{
			Console.WriteLine("Está en un peso normal");
		}

		else if (25 <= imc && imc <= 29.9)
		{
			Console.WriteLine("Está en sobrepeso");
		}

		else
		{
			Console.WriteLine("Está en obesidad");
		}

		Console.WriteLine("Su índice de masa corporal es: " + imc);
	}
}
