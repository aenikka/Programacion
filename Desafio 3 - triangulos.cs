using System;

namespace Desafío_3___triangulos
{
    class Program
    {
		public static void Main()
		{
			Console.Write("Ingrese c en grados y z: ");
			double cGrados = double.Parse(Console.ReadLine());
			double z = double.Parse(Console.ReadLine());

			double cRadianes = cGrados * (Math.PI / 180);

			double t = z / Math.Sin(cRadianes);

			Console.WriteLine("El valor de t es: " + t);



			double y = Math.Sqrt((t * t) - (z * z));

			Console.WriteLine("El valor de y es: " + y);

			double a = 180 - (cGrados + 90);
			Console.WriteLine("El valor de a es: " + a);


		}
	}
}
