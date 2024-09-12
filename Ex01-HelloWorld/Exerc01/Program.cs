using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1=0, n2=0, med;
            Console.WriteLine("Informe o valor para N1: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor para N2: ");
            n2 = float.Parse(Console.ReadLine());
            med = (n1 + n2) / 2;
            Console.WriteLine($"N1: {n1}\nN2: {n2}\nMedia: {med}");
            if ((med < 6) && (med >= 0))
            {
                Console.WriteLine("Reprovado :)!");
            }
            else
            {
                Console.WriteLine("Aprovado :( !");
                Console.WriteLine("Parabéns!!!");
            }
            Console.ReadKey();
            
        }
    }
}
