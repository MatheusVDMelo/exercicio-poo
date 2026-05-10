using exercicioPoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPoo
{
    public class Produto

    {
        public string Nome;
        public decimal Preco;
        public void ExibirNomeValorProduto()
        {
            Console.WriteLine($"Produto: {Nome}, Valor: {Preco}");
        }
    }
}
