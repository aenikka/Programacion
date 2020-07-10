using System;

namespace Desafio_Binarios
{
    class Program
    {
		public static void Main()
		{
			Console.Write("Ingrese 5 enteros: ");
			int b4 = int.Parse(Console.ReadLine());
			int b3 = int.Parse(Console.ReadLine());
			int b2 = int.Parse(Console.ReadLine());
			int b1 = int.Parse(Console.ReadLine());
			int b0 = int.Parse(Console.ReadLine());

			int b4Decimal = b4 * 16;
			int b3Decimal = b3 * 8;
			int b2Decimal = b2 * 4;
			int b1Decimal = b1 * 2;
			int b0Decimal = b0 * 1;

			Console.WriteLine("El valor en decimal es: " + (b4Decimal + b3Decimal + b2Decimal + b1Decimal + b0Decimal));


		}
	}
}
