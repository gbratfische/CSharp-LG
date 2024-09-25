using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace associacao01
{
    internal class Endereco
    {
        //property gera metodo get e set dos parametros
        public string Logradouro { set; get; }
        public string Tipo_logradouro { set; get; }
        public string Localidade { set; get; }
        public string UF { set; get; }
        public string Bairro { set; get; }
        public int CEP { set; get; }
        public int Numero { set; get; }
        public string Complemento { set; get; }

        //ctrl+. = gerar metodo construtor
        public Endereco(string logradouro, string tipo_logradouro, string localidade, string uF, string bairro, int cEP, int numero, string complemento)
        {
            Logradouro = logradouro;
            Tipo_logradouro = tipo_logradouro;
            Localidade = localidade;
            UF = uF;
            Bairro = bairro;
            CEP = cEP;
            Numero = numero;
            Complemento = complemento;
        }

        public override string ToString()
        {
            return $"Dados do Endereço:\n{Tipo_logradouro} {Logradouro}, {Numero}, {Bairro}\n{Localidade}-{UF}\n{Complemento}\n{CEP}";
        }
    }
}
