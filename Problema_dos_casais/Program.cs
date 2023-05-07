using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_dos_casais
{
    class Program
    {
        public static bool verioficarCasal(int n, List<int> numeros)
        {
            if (numeros.Count == n)
            {
                int cont = 0;
                while (cont < numeros.Count)
                {
                    if (cont + 1 >= numeros.Count)
                    {
                        break;
                    }
                    if ((numeros[cont] % 2 == 0 && numeros[cont + 1] % 2 == 0) || (numeros[cont] % 2 != 0 && numeros[cont + 1] % 2 != 0))
                    {
                        return false;
                    }

                    cont += 2;
                }
            }
            else {
                return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numeros =Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            if (verioficarCasal(n, numeros))
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("N");
            }
            
            
        }
    }
}
