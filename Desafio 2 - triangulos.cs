using System;

namespace Desafio_2___Triangulos
{
    class Program
    {
        public static void Main()
	{
		Console.Write("Ingrese t y a en grados: ");
		double t = double.Parse(Console.ReadLine());
		double aGrados = double.Parse(Console.ReadLine());
		
		double aRadianes = aGrados*(Math.PI/180);
		
		double y = Math.Sin(aRadianes)/(1/t);
		
		Console.WriteLine("El valor de y es: " + y);
		
		double z = Math.Sqrt((t*t)-(y*y));
		
		Console.WriteLine("El valor de z es: " + z);
		
		double c = 180 - (aGrados + 90);
		Console.WriteLine("El valor de c es: " + c);
		
		
	}
    }
}
