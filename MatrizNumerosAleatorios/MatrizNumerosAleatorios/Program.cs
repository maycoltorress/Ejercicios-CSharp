using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizNumerosAleatorios
{
    class Program
    {

        public int repetidos(int [,]matriz, int numero, int filas,int columnas)
        {
            for(int i =0; i<filas; i++)
            {
               for(int j =0; j<columnas; j++)
               {
                  if (matriz[i,j]==numero) 
                      return 1;
               }
            }
            return 0;
        
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int retorno =0;
            int numero;

            Console.Write("Ingrese numero de filas de la matriz >> ");
            int filas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese numero de columnas de la matriz >> ");
            int columnas = Convert.ToInt32(Console.ReadLine());

            int dimension = filas * columnas;

            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = 0;
                }
            }

            Program x = new Program();

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    numero = r.Next(1, dimension+1);
                    retorno = x.repetidos(matriz, numero, filas, columnas);
                    if (retorno == 1)
                        j--;
                    else
                        matriz[i, j] = numero;
                    retorno = 0;
                }
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
