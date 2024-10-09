using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont;
            int par=0;
            int impar=0;

            int[] vetor = new int[10];
            int[] vetorpar = new int[10];
            int[] vetorimpar = new int[10];

            for (cont=0; cont<vetor.Length; cont++)
            {
                Console.Write($"Digite o valor {cont + 1} do vetor: ");
                vetor[cont] = int.Parse(Console.ReadLine());
                if (vetor[cont] %2 ==0 )
                {
                    vetorpar[par] = vetor[cont];
                    par++;
                }
                else
                {
                    vetorimpar[impar]= vetor[cont];
                    impar++;
                }
            }

            for (cont=0; cont<vetor.Length; cont++)
            {
                Console.WriteLine($"O valor {cont+1} do vetor é:  {vetor[cont]}");
            }
            for (cont = 0; cont < par; cont++)
            {
                Console.WriteLine($"O valor {cont+1} do vetor par é: {vetorpar[cont]}");
            }
            for (cont = 0; cont < impar; cont++)
            {
                Console.WriteLine($"O valor {cont+1} do vetor é: {vetorimpar[cont]}");
            }

            Console.ReadKey();
        }
    }
}
