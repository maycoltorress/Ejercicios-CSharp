using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primosRango
{
    class Program
    {
        static void Main(string[] args)
        {
            int contPrimos = 0;
            
            for (int n1 = 1; n1 <= 10000; n1++)
            {
                int suma = 0;
                for (int i = 1; i <= n1; i++)          
                {
                    if (n1 % i == 0)
                        suma ++;
                }

                if (suma == 2)
                {
                    contPrimos++;
                    Console.WriteLine(n1);
                    System.Threading.Thread.Sleep(1);
                }
                
            }
            Console.WriteLine("Hay: {0,2} Numeros primos", contPrimos);
            Console.ReadKey(); //Para que no se ciere
        }
    }
}
