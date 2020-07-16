using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Ingrese los valores para a, b y c: ");
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());

		double discriminante = (b * b) - 4 * a * c;

		double solucionmenos = (-b - Math.Sqrt(discriminante)) / (2 * a);
		double solucionmas = (-b + Math.Sqrt(discriminante)) / (2 * a);

		if (discriminante == 0)
			Console.WriteLine("Hay una sola solucion.");
		Console.WriteLine("La solucion es: " + solucionmas);

		if (discriminante > 0)
			Console.WriteLine("Hay dos soluciones.");
		Console.WriteLine("La solucion 1 es: " + solucionmas);
		Console.WriteLine("La solucion 2 es: " + solucionmenos);

		if (discriminante < 0)
			Console.WriteLine("No existe solucion real.");

	}
}
