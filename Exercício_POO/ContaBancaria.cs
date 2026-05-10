using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPoo
{
    internal class ContaBancaria
{
        public string Titular;
        public decimal Saldo;
        public decimal Transacao;
        public void InserirValor()
        {
            Console.WriteLine("Informe valor desejado:");
            Transacao = decimal.Parse(Console.ReadLine());
        }
        public void Depositar() 
        {
            Saldo += Transacao;
        }
        public void Sacar()
        {
            if (Saldo >= Transacao)
            {
                Saldo -= Transacao;
                Console.WriteLine($"Seu atual: {Saldo}");
            }
            else {
                Console.WriteLine($"Saldo isuficiente, saldo atual: {Saldo}");
            }
        }

    }
}
