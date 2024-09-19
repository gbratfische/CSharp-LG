using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace associacao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Endereco endereco = new Endereco("Precide Scarpino", "Rua", "Araraquara", "São Paulo", "Jd Santa Clara", 14811380, 126, "Fatec Araraquara");
            
            Pessoa pessoa = new Pessoa("Guilherme", "190", new Endereco("Precide Scarpino", "Rua", "Araraquara", "São Paulo", "Jd Santa Clara", 14811380, 126, "Fatec Araraquara"), 29);
            Console.WriteLine(pessoa.ToString());
            Console.ReadKey();
        }
    }
}
