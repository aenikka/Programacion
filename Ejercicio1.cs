﻿using System;

namespace Reto1
{
    class Program
    {
		public static void Main()
		{
			// Entrada del usuario de la variable X1
			Console.Write("Ingrese X1: ");
			double x1 = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable Y1
			Console.Write("Ingrese Y1: ");
			double y1 = double.Parse(Console.ReadLine());

			// Entrada del usuario de las variables restantes
			// ...
			Console.Write("Ingrese X2: ");
			double x2 = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable Y1
			Console.Write("Ingrese Y2: ");
			double y2 = double.Parse(Console.ReadLine());

			double m = (y2 - y1) / (x2 - x1);
			Console.WriteLine("La pendiente es: " + m);

			double b = y1 - (m * x1);
			Console.WriteLine("El intercepto es: " + b);

			double distancia = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
			Console.WriteLine("La distancia es: " + distancia);


		}
	}
