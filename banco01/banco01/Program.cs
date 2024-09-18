using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            float valor = 0;
            ContaBancaria contaBancaria = new ContaBancaria();

            do
            {
            Console.WriteLine("Informe a ação desejada 1-Depositar\n2-Sacar\n3-Ver Saldo\n0-Sair");
            opcao=int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        contaBancaria.Depositar(10);
                        break;
                    case 2:
                        if (contaBancaria.Sacar(5))
                        {
                            Console.WriteLine("Saque efetuado!");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente;");
                        }
                        break;
                    case 3:
                        Console.WriteLine(contaBancaria.ToString());
                        break;
                    case 0:
                        Console.WriteLine("Fim do programa");
                        break;
                    default:
                        Console.WriteLine(("Opção incorreta!"));
                        break;
                }
            } while (opcao != 0);
            Console.ReadKey();
        }
    }
}
