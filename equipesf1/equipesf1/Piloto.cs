using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipesf1
{
    internal class Piloto
    {
        public string NomePiloto { get; set; }
        public int IdadePiloto { get; set; }
        public string NacionalidadePiloto { get; set; } 
        public int PontosPiloto { get; set; }
        public float MelhorVolta { get; set; }
        public DateTime DataNascimento { get; set; }

        public Piloto(string nomePiloto, int idadePiloto, string nacionalidadePiloto, int pontosPiloto, float melhorVolta, DateTime dataNascimento)
        {
            NomePiloto = nomePiloto;
            IdadePiloto = idadePiloto;
            NacionalidadePiloto = nacionalidadePiloto;
            PontosPiloto = pontosPiloto;
            MelhorVolta = melhorVolta;
            DataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            return $"\nDados do Piloto:\nNome: {NomePiloto}\nIdade: {IdadePiloto}\nNacionalidade: {NacionalidadePiloto}\nData de Nascimento: {DataNascimento}\nNúmero de Pontos: {PontosPiloto}\nMelhor Volta (segundos): {MelhorVolta}";
        }
    }
}
