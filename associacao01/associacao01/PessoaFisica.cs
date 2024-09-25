using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace associacao01
{
    internal class PessoaFisica:Pessoa
    {
        public string CPF { get; set; }

        public PessoaFisica(string nome, string telefone, Endereco endereco, int idade, string cPF): base(nome, telefone, endereco, idade)
        {
            //:base retorna os valores de herança da classe Pessoa
            CPF = cPF;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCPF: {CPF}";
        }
    }
}
