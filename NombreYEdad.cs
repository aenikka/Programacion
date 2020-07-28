using System;

public class Program
{
	public static void Main()
	{
		double total = 0;
		Console.Write("Ingrese el número de datos (n): ");
		int n = int.Parse(Console.ReadLine());
		int i = 0, max = 0, min = 0;
		string nombre = ".", nombremax = ".", nombremin = ".";


		while (i < n)
		{
			Console.WriteLine("Nombre: ");
			nombre = Console.ReadLine();
			Console.Write("Edad: ");
			int edad = int.Parse(Console.ReadLine());

			if (i == 0)
			{
				max = edad;
				min = edad;
				nombremax = nombre;
				nombremin = nombre;
			}
			if (edad > max)
			{
				nombremax = nombre;
				max = edad;
			}

			if (edad < min)
			{
				nombremin = nombre;
				min = edad;
			}

			total += edad;
			i++;
		}

		double promedio = total / n;
		Console.WriteLine("Promedio = " + promedio);
		Console.WriteLine("Edad mayor = " + max + " Nombre = " + nombremax);
		Console.WriteLine("Edad menor = " + min + " Nombre = " + nombremin);
	}
}