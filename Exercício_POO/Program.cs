using exercicioPoo;

//Exercício 01
//
//Produto Produto01 = new Produto()
//{
//    Nome = "Sabão",
//    Preco = 2
//};
//Produto Produto02 = new Produto()
//{
//    Nome = "Refrigerante",
//    Preco = 5
//};

//Produto01.ExibirNomeValorProduto();
//Produto02.ExibirNomeValorProduto();


//Exercício 02
//
//Pessoa Pessoa01 = new Pessoa()
//{
//    Nome = "Larissa",
//    Idade = 32
//};
//Pessoa01.ExibirNomeIdadePessoa();

//Exercício 03
//
//Aluno Pessoa01 = new Aluno()
//{
//Nome = "Larissa",
//Nota = 1,
//};
//Pessoa01.VerificaSituacao();

//Exercício 04
//

//ContaBancaria Usuario01 = new ContaBancaria
//{
//    Saldo = 0
//};
//byte opcao = 0;
//while (opcao != 3)
//{
//    Console.WriteLine("Informe operação deseja:");
//    Console.WriteLine("1 para depósito.");
//    Console.WriteLine("2 para saque.");
//    Console.WriteLine("3 para sair.");
//    opcao = byte.Parse(Console.ReadLine());
//    Console.Clear();
//    if (opcao != 3)
//    {
//        Usuario01.InserirValor();
//        switch (opcao)
//        {
//            case 1:
//                Console.Clear();
//                Usuario01.Depositar();
//                Console.WriteLine($"Seu atual: {Usuario01.Saldo}");
//                break;
//            case 2:
//                Console.Clear();
//                Usuario01.Sacar();
//                break;
//        }
//    }
//    else
//    {
//        Console.WriteLine($"Acesso encerrado com sucesso.");
//        return;
//    }
//}

//Exercício 05
//
//Produto Produto01 = new Produto() { Nome = "Detergente", Preco = 8 };
//Produto Produto02 = new Produto() { Nome = "Água sanitária", Preco = 9 };
//Produto Produto03 = new Produto() { Nome = "Sabão em pó", Preco = 18 };
//Produto[] Lista = [Produto01, Produto02, Produto03];
//foreach (Produto Indice in Lista)
//{
//    Console.WriteLine($"Produto:{Indice.Nome}, Preco:{Indice.Preco}");
//}
//;

//Exercício 06
//
//Pessoa Buscador = new Pessoa();
//
//Buscador.VerificarNomeLista();
//bool NomeLocalizado = false;
//
//Pessoa Pessoa01 = new Pessoa() { Nome = "Iago" };
//Pessoa Pessoa02 = new Pessoa() { Nome = "Rafaela" };
//Pessoa Pessoa03 = new Pessoa() { Nome = "Marco" };
//Pessoa Pessoa04 = new Pessoa() { Nome = "Amanda" };
//Pessoa[] Lista = [Pessoa01, Pessoa02, Pessoa03, Pessoa04];
//
//foreach (Pessoa Indice in Lista)
//{
//    if (Indice.Nome == Buscador.Nome)
//    {
//        NomeLocalizado = true;
//        break;
//    }
//}
//if (NomeLocalizado)
//{
//    Console.WriteLine("Nome na lista");
//}
//else
//{
//    Console.WriteLine("Nome fora da lista");
//};
//Exercício 07

//Produto Produto01 = new Produto() { Nome = "Detergente", Preco = 18 };
//Produto Produto02 = new Produto() { Nome = "Água sanitária", Preco = 9 };
//Produto Produto03 = new Produto() { Nome = "Sabão em pó", Preco = 5 };
//Produto[] Lista = [Produto01, Produto02, Produto03];
//Produto ItemValorMaisAlto = new Produto();
//
//foreach (Produto Indice in Lista)
//{
//    if (Indice.Preco > ItemValorMaisAlto.Preco) 
//    {
//        ItemValorMaisAlto.Nome = Indice.Nome;
//        ItemValorMaisAlto.Preco = Indice.Preco;
//    }
//}
//Console.WriteLine($"O item com maior preço é {ItemValorMaisAlto.Nome} com valor de {ItemValorMaisAlto.Preco} reais");
//;
//Exercício 08
//Aluno[] Matricula = new Aluno[3];

//for (int i = 0; i < Matricula.Length; i++)
//{
//    Matricula[i] = new Aluno();
//    Console.Write("Informe o nome do novo aluno:");
//    Matricula[i].Nome = Console.ReadLine();
//};
//Console.WriteLine("Alunos matriculados: ");
//foreach (Aluno i in Matricula) 
//{
//    Console.WriteLine(i.Nome);
//};
//Exercício 09
ContaBancaria Usuario01 = new ContaBancaria
{
    Titular = "",
    Saldo = 0
};
int opcao = 0;
while (opcao != 5)
{
    Console.WriteLine("Informe operação deseja:");
    Console.WriteLine("1 para cadastrar conta.");
    Console.WriteLine("2 para depositar saldo.");
    Console.WriteLine("3 para sacar saldo.");
    Console.WriteLine("4 verificar saldo");
    Console.WriteLine("5 para sair.");
    opcao = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Informe usuário:");
            Usuario01.Titular = Console.ReadLine();
            Console.WriteLine("Conta cadastrada com sucesso.");
            break;
        case 2:
            Console.Clear();
            Usuario01.InserirValor();
            Usuario01.Depositar();
            Console.WriteLine($"Seu atual: {Usuario01.Saldo}");
            break;
        case 3:
            Console.Clear();
            Usuario01.InserirValor();
            Usuario01.Sacar();
            break;
        case 4:
            Console.Clear();
            Usuario01.ConsultarSaldo();
            break;
        case 5:
            Console.WriteLine($"Acesso encerrado com sucesso.");
            break;
    }
}