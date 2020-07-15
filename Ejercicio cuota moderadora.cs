using System;

namespace Ejercicio_cuota_moderadora
{
    class Program
    {
		public static void Main()
		{
			Console.WriteLine("Ingrese su salario: ");
			double salario = double.Parse(Console.ReadLine());
			int smmlv = 877803;


			if (salario < (smmlv * 2))
			{
				Console.WriteLine("Usted es Tarifa A, y su cuota moderadora es $3.400");

			}

			else if (2 * smmlv <= salario && salario < 5 * smmlv)
			{
				Console.WriteLine("Usted es Tarifa B, y su cuota moderadora es $13.500");
			}

			else if (salario >= 5 * smmlv)
			{
				Console.WriteLine("Usted es Tarifa C, y su cuota moderadora es $35.600");
			}

		}
	}
}
