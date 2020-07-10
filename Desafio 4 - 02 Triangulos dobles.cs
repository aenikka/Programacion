using System;

namespace Desafio_4_02_Triangulos_dobles
{
    class Program
    {
		public static void Main()
		{
			Console.Write("Ingrese w, t, c en grados: ");
			double w = double.Parse(Console.ReadLine());
			double t = double.Parse(Console.ReadLine());
			double cGrados = double.Parse(Console.ReadLine());

			double eGrados = (180 - cGrados);
			double eRadianes = eGrados * (Math.PI / 180);
			double dRadianes = Math.Asin(t * (Math.Sin(eRadianes) / w));
			double dGrados = dRadianes * (180 / Math.PI);
			double bGrados = 180 - (eGrados + dGrados);

			double bRadianes = bGrados * (Math.PI / 180);
			double x = Math.Sin(bRadianes) * (t / Math.Sin(dRadianes));

			Console.WriteLine("El valor de x es: " + x);

		}
	}
}
