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

ContaBancaria Usuario01 = new ContaBancaria
{
    Saldo = 0
};
byte opcao = 0;
while (opcao != 3)
{
    Console.WriteLine("Informe operação deseja:");
    Console.WriteLine("1 para depósito.");
    Console.WriteLine("2 para saque.");
    Console.WriteLine("3 para sair.");
    opcao = byte.Parse(Console.ReadLine());
    Console.Clear();
    if (opcao != 3)
    {
        Usuario01.InserirValor();
        switch (opcao)
        {
            case 1:
                Console.Clear();
                Usuario01.Depositar();
                Console.WriteLine($"Seu atual: {Usuario01.Saldo}");
                break;
            case 2:
                Console.Clear();
                Usuario01.Sacar();
                break;
        }
    }
    else
    {
        Console.WriteLine($"Acesso encerrado com sucesso.");
        return;
    }
}

