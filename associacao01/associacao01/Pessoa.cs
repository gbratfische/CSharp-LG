using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace associacao01
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, string telefone, Endereco endereco, int idade)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Idade = idade;
        }

        public Pessoa()
        {
        }

        public override string ToString()
        {
            return $"Dados da pessoa:\nNome: {Nome}"+
                   $"\nTelefone: {Telefone}"+
                   $"\nIdade: {Idade}"+
                   $"\n{Endereco.ToString()}";
        }

    }
}
