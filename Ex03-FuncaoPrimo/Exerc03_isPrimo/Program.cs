using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc03_isPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = ler_Int(1);
            Console.Write(valor);
            if (isPrimo(valor))
                Console.Write(", é Primo!");
            else
                Console.Write(", Não é Primo!");
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static bool isPrimo(int valor)
        {
            for (int i = 2; i < valor; i++)
                if (valor % i == 0)
                    return false;
            return true;
        }

        static int ler_Int(int inicio)
        {
            int aux = 0;
            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine($"Infome um valor inteiro, maior do que {inicio}:");
                        aux = int.Parse(Console.ReadLine());
                    } while (aux <= inicio);
                    return aux;
                }
                catch (Exception e)
                {
                    Console.WriteLine("VALOR INVÁLIDO!");
                }
            } while (true);
        }
    }
}
