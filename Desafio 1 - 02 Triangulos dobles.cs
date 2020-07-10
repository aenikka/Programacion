using System;

namespace Desafio_1_02_Triangulos_dobles
{
    class Program
    {
		public static void Main()
		{
			Console.Write("Ingrese b en grados, z, y: ");
			double bGrados = double.Parse(Console.ReadLine());
			double z = double.Parse(Console.ReadLine());
			double y = double.Parse(Console.ReadLine());

			double t = Math.Sqrt((z * z) + (y * y));
			double cRadianes = Math.Asin(z * (1 / t));
			double cGrados = cRadianes * (180 / Math.PI);
			double eGrados = 180 - cGrados;
			double dGrados = 180 - (bGrados + eGrados);

			double bRadianes = bGrados * (Math.PI / 180);
			double dRadianes = dGrados * (Math.PI / 180);

			double x = Math.Sin(bRadianes) * (t / Math.Sin(dRadianes));

			Console.WriteLine("El valor de x es: " + x);

		}
	}
}
