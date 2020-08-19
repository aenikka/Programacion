using System;
using System.Xml.Schema;

namespace ArregloDatos
{
    class Program
    {
        public static void Main()
        {
            string[] nombres = { "Tanjiro", "Nezuko", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 165, 153, 164.5, 164, 180, 156, 176 };
            double total = 0;
            double desviacion = 0;
            double numerador = 0;
            double minimo = 190;
            string cercano = ".";
            double estaturacercano = 0;

            for (int i = 0; i < estatura.Length; i++) {
                 total += estatura[i];
            }
            Console.WriteLine("Total: " + total);

            double promedio = total / 7;
            Console.WriteLine("Promedio: " + promedio);

            double[] distancias = new double[estatura.Length];


            for (int i = 0; i < estatura.Length; i++)
            {
                 distancias[i] = promedio - estatura[i];

                if (distancias[i] < 0)
                {
                    distancias[i] = distancias[i] * -1;
                }

                if (distancias[i] < minimo) {

                    minimo = distancias[i];
                    cercano = nombres[i];
                    estaturacercano = estatura[i];



                }

                Console.WriteLine("La distancia del dato " + i + " y el promedio es de: " + distancias[i]);
        
            }

            Console.WriteLine("El nombre de la persona más cercana al promedio es: " + cercano + " y su estatura es: " + estaturacercano);


            for (int c = 0; c < estatura.Length; c++) { 
            
            numerador += (estatura[c] - promedio) * (estatura[c] - promedio);

                desviacion = Math.Sqrt(numerador / (estatura.Length));

            }
            Console.WriteLine("La desviación es: " + desviacion);

        }
    }
}
