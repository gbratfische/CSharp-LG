using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Exerc02_Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, resultado;
            n1 = ler_Float(0, 10);
            n2 = ler_Float(0, 10);
            n3 = ler_Float(0, 10);
            resultado = MEDIA(n1, n2, n3);
            Console.Write($"\n\nNotas do aluno:\nN1:\t{n1:F2}\nN2:\t{n2:F2}\nN3:\t{n3:F2}\nMédia:\t{resultado:F2}\nSituação:\t");
            if (resultado >= 0 && resultado < 3)
                Console.Write("Reprovado!");
            else
                if (resultado < 6)
                    Console.Write("Exame!");
                else
                    Console.Write("Aprovado!");

            Console.WriteLine("\n\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static float MEDIA(float n1, float n2, float n3)
        {
            return ((n1 + n2 + n3) / 3);
        }

        static float ler_Float(float inicio, float fim)
        {
            float aux = 0;
            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine($"Infome um valor real, entre {inicio} e {fim}:");
                        aux = float.Parse(Console.ReadLine());
                    } while (aux < 0 || aux > 10);
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
