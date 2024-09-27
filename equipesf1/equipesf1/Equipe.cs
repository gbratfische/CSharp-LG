using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipesf1
{
    internal class Equipe
    {
        public string NomeEquipe { get; set; }
        public Piloto Piloto { get; set; }
        public int PontosEquipe { get; set; }
        public DateTime DataCriacao { get; set; }
        public float ComprimentoCarro { get; set; }

        public Equipe(string nomeEquipe, Piloto piloto, int pontosEquipe, DateTime dataCriacao, float comprimentoCarro)
        {
            NomeEquipe = nomeEquipe;
            Piloto = piloto;
            PontosEquipe = pontosEquipe;
            DataCriacao = dataCriacao;
            ComprimentoCarro = comprimentoCarro;
        }
        


        public override string ToString()
        {
            return $"Dados da Equipe:\nNome da Equipe: {NomeEquipe}\nData de Criação: {DataCriacao}\nPontos da Equipe: {PontosEquipe}\nComprimento do Carro (metros): {ComprimentoCarro}" + Piloto.ToString();
        }
    }
}
