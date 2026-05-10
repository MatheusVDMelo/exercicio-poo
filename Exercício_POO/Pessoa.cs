using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPoo
{
    internal class Pessoa
    {

        public string Nome;
        public int Idade;
        public void ExibirNomeIdadePessoa()
        {
            Console.WriteLine($"Pessoa:{Nome}, Idade:{Idade} anos");
        }
        public void VerificarNomeLista()
        {
            Console.WriteLine("Informe o nome desejado:");
            Nome = Console.ReadLine();
        }
    };

}
