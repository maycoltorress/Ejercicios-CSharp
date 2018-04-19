using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizPorVector
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese numeros de filas: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese numeros de columnas: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese largo del vector: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = 1;

            int[,] m1 = new int[a, b];
            int[,] m2 = new int[c, d];
            //int[,] m3 = new int[a, d];

            if (b == c)
            {
                //Llenar la matriz
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write("Ingrese numero de matriz 1 en posicion {0},{1} : ", i, j);
                        m1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }

                }
                //Llenar el vector
                for (int i = 0; i < c; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        Console.Write("Ingrese numero en vector, posicion {0},{1} : ", i, j);
                        m2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }

                }

                //Multiplicar
                for (int i = 0; i < a; i++)
                {
                    int suma=0;
                    for (int j = 0; j < b; j++)
                    {
                        suma+=m1[i,j]*m2[j,0];
                    }
                    Console.WriteLine(suma);
                    //m3[i,0] = suma;

                }
                
            }
            else
                Console.WriteLine("El ancho de la matriz no coincide con la altura del vector");
            Console.ReadKey(); //Para que no se ciere
        }
    }
}
