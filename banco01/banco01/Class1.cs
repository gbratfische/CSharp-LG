using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco01
{
    internal class ContaBancaria
    {
        string numeroConta;
        float saldo;

        public ContaBancaria()
        {
            Random rnd = new Random();
            numeroConta = rnd.Next(100).ToString();
            saldo = 0;
        }
        public void Depositar(float valor)
        {
            saldo += valor;
        }
        public bool Sacar(float valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public float getSaldo() 
        { 
            return saldo; 
        }
        public override string ToString() 
        { 
            return $"Conta: {numeroConta}\nSaldo: {saldo}";
        }
    }
}
