using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizPorEscalar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese numeros de filas: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese numeros de columnas: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Escalar: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int[,] m1 = new int[a, b];
            

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("Ingrese numero en posicion {0},{1} : ", i, j);
                    m1[i, j] = Convert.ToInt32(Console.ReadLine());
                    m1[i, j] = m1[i, j] * x;                   
                }

            }

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(m1[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
