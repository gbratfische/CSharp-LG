using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipesf1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Equipe equipe = null; ;
            Piloto piloto;

            do
            {
                Console.WriteLine("Digite a opção desejada:\n1-Adicionar Equipe\n2-Adicionar Piloto\n3-Conferir Equipe\n0-Sair do Programa");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        equipe = CriarEquipe();
                        Console.WriteLine(equipe.ToString());
                        break;
                    //case 2:
                    //    piloto = criarpiloto();
                    //    break;
                    case 3:
                        if (equipe != null)
                            Console.WriteLine(equipe.ToString());
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            while (opcao != 0);
        }
        static Equipe CriarEquipe()
        {
            Console.WriteLine("Informe o nome da equipe: ");
            string nomeEquipe = Console.ReadLine();

            Console.WriteLine("Informe os pontos obtidos pela equipe: ");
            int pontosEquipe = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a data de criação da equipe: ");
            DateTime dataCriacao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe o comprimento do carro da equipe, em metros: ");
            float comprimentoCarro = float.Parse(Console.ReadLine());

            Piloto piloto = CriarPiloto();

            return new Equipe(nomeEquipe, piloto, pontosEquipe, dataCriacao, comprimentoCarro);

        }

        static Piloto CriarPiloto()
        {
            Console.WriteLine("Informe o nome do piloto: ");
            string nomePiloto = Console.ReadLine();

            Console.WriteLine("Informe a idade do piloto: ");
            int idadePiloto = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nacionalidade do piloto: ");
            string nacionalidadePiloto = Console.ReadLine();

            Console.WriteLine("Informe os pontos do piloto: ");
            int pontosPiloto = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a melhor volta do piloto, em segundos: ");
            float melhorVolta = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nascimento do piloto: ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            return new Piloto(nomePiloto, idadePiloto, nacionalidadePiloto, pontosPiloto, melhorVolta, dataNascimento);
        }
    }
}
