using System;

namespace Desafio_3_02_Triangulos_dobles
{
    class Program
    {
		public static void Main()
		{
			Console.Write("Ingrese w, d en grados, x: ");
			double w = double.Parse(Console.ReadLine());
			double dGrados = double.Parse(Console.ReadLine());
			double x = double.Parse(Console.ReadLine());

			double baGrados = 180 - (dGrados + 90);
			double baRadianes = baGrados * (Math.PI / 180);
			double y = (Math.Sin(baRadianes) * w) - x;

			Console.WriteLine("El valor de y es: " + y);

		}
	}
}
