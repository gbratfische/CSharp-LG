using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc04_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = ler_Int(-1);
            int resultado = Fatorial(valor);
            Console.WriteLine($"{valor}! = {resultado}");
            Console.ReadKey();
        }

        //static int Fatorial(int valor)
        //{ 
        //int resultado = 1;
        //for (int i = 2; i <= valor; i++)
        //    resultado *= i;
        //    //resultado = resultado * i;
        //return resultado;
        //}
        static int Fatorial(int valor)
        {
            if (valor == 0)
                return 1;
            else
                return valor * Fatorial(valor - 1);
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
