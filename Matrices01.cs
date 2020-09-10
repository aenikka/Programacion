using System;

namespace Matrices01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int n = 10;
            int m = 15;

            double equis = 0;
            double os = 0;
            double rayitas = 0;

            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";

                }

            }

            //ENTRADA
            Console.WriteLine("ENTRADA: "); 
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }

                Console.Write("|\n");
            }





            //PROCESO

            

                    for (int i = 0; i < tablero.GetLength(0); i++)
                    {
                        for (int j = 0; j < tablero.GetLength(1) - 2; j++)
                        {
                            if (tablero[i, j] == tablero[i, j + 1] && tablero[i, j + 1] == tablero[i, j + 2])
                            {
                                if (tablero[i, j] == "X")
                                {
                                    salida[i, j] = "1";
                                    salida[i, j + 1] = "1";
                                    salida[i, j + 2] = "1";


                                }

                                if (tablero[i, j] == "O")
                                {
                                    salida[i, j] = "2";
                                    salida[i, j + 1] = "2";
                                    salida[i, j + 2] = "2";
                                }

                            }

                        }


                    }

                    for (int i = 0; i < tablero.GetLength(0)-2; i++)
                    {
                        for (int j = 0; j < tablero.GetLength(1); j++)
                        {
                            if (tablero[i, j] == tablero[i + 1, j] && tablero[i + 1, j] == tablero[i + 2, j])
                            {

                                if (tablero[i, j] == "X")
                                {
                                    salida[i, j] = "1";
                                    salida[i + 1, j] = "1";
                                    salida[i + 2, j] = "1";
                                }

                                if (tablero[i, j] == "O")
                                {
                                    salida[i, j] = "2";
                                    salida[i + 1, j] = "2";
                                    salida[i + 2, j] = "2";
                                }

                            }

                        }


                    }

                    


            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    if (tablero[i, j] == "X")
                    {

                        equis++;
                    }

                    if (tablero[i, j] == "O")
                    {

                        os++;
                    }

                    if (tablero[i, j] == "-")
                    {

                        rayitas++;
                    }

                }


            }



                    double total = os + rayitas + equis;

            double porcentajeequis = (equis / total) * 100;
            double porcentajeos = (os / total) * 100;
            double porcentajerayitas = (rayitas / total) * 100;



            //SALIDA
            Console.WriteLine("\nSALIDA: "); 
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }

                Console.Write("|\n");
            }

            Console.Write("|\n");


            Console.WriteLine("Porcentaje de X:  " + porcentajeequis + "%");
            Console.WriteLine("Porcentaje de O:  " + porcentajeos + "%");
            Console.WriteLine("Porcentaje de -:  " + porcentajerayitas + "%");

        }
                

        
    }
}


