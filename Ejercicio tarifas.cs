using System;

namespace Ejercicio_tarifas
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
				Console.WriteLine("Usted es Tarifa A");
			}

			else if (2 * smmlv <= salario && salario < 4 * smmlv)
			{
				Console.WriteLine("Usted es Tarifa B");
			}

			else if (salario >= 4 * smmlv)
			{
				Console.WriteLine("Usted es Tarifa C");
			}

		}
	}
}
