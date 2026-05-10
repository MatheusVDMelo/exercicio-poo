using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPoo
{
    internal class Aluno : Pessoa // Classe herdade de Pessoa.cs para não precisar inserir dados desnecessários.
{
        public double Nota;

        public void VerificaSituacao() 
        {
            if (Nota >= 7) {
                Console.WriteLine($"Aluno(a) {Nome} Aprovado(a).");
                Console.WriteLine($"Mérido: {Nota}");
                return;
            }
            Console.WriteLine($"Aluno(a) {Nome} Reprovado(a).");
            Console.WriteLine($"Mérido: {Nota}");
        }
}
}
