using System;

namespace Ejercicio_Cotización_Salario
{
    class Program
    {
		public static void Main()
		{

			double darl = 0;

			Console.WriteLine("Ingrese su tipo de contrato: 1 si es independiente o 2 si es dependiente: ");
			// Entrada de datos
			int contrato = int.Parse(Console.ReadLine()); // 1 = Independiente | 2 = Dependiente
			Console.WriteLine("Ingrese su salario: ");
			double salario = int.Parse(Console.ReadLine());


			double bcotizacion = salario * 0.4;
			if (bcotizacion <= 877803)
			{
				bcotizacion = 877803;
			}

			if (contrato == 1)
			{ // Independiente
				Console.WriteLine("Ingrese un número de 1 a 5 equivalente a la clase del riesgo: ");
				int riesgo = int.Parse(Console.ReadLine());


				double dpension = bcotizacion * 0.16;
				double deps = bcotizacion * 0.125;

				if (riesgo == 1)
				{
					darl = bcotizacion * 0.0052;
				}
				else if (riesgo == 2)
				{
					darl = bcotizacion * 0.01044;
				}
				else if (riesgo == 3)
				{
					darl = bcotizacion * 0.02436;
				}
				else if (riesgo == 4)
				{
					darl = bcotizacion * 0.04350;
				}

				else if (riesgo == 5)
				{
					darl = bcotizacion * 0.06960;
				}

				double dtotales = dpension + deps + darl;

				double salarioreal = salario - dtotales;
				double salarioanual = salarioreal * 12;

				Console.WriteLine("Su salario real mensual es: " + salarioreal);
				Console.WriteLine("Su salario anual es: " + salarioanual);

			}
			else
			{
				double dpension = bcotizacion * 0.04;
				double deps = bcotizacion * 0.04;
				darl = bcotizacion * 0;

				double dtotales = dpension + deps + darl;

				double salarioreal = salario - dtotales;
				double salarioanual = (salarioreal * 12) + salario;

				Console.WriteLine("Su salario real mensual es: " + salarioreal);
				Console.WriteLine("Su salario anual es: " + salarioanual);

			}
		}
	}
}
