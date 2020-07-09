using System;

namespace Desafío_1___Triángulos
{
    class Program
    {
		public static void Main()
		{
			Console.Write("Ingrese y y z: ");
			double y = double.Parse(Console.ReadLine());
			double z = double.Parse(Console.ReadLine());

			double t = Math.Sqrt((z * z) + (y * y));
			Console.WriteLine("El valor de t es: " + t);

			double cRadianes = Math.Asin(z / t);
			double cGrados = cRadianes * (180 / Math.PI);

			Console.WriteLine("El valor de c es: " + cGrados);

			double a = 180 - (90 + cGrados);
			Console.WriteLine("El valor de a es: " + a);
		}
	}
}

