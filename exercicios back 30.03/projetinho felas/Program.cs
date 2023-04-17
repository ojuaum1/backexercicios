// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair


// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

//entrada
while (sair)
{
    Console.WriteLine(@$"Bem vindo ao jj-air-lines");


Console.Write($"digite seu nome: ");
string nome = Console.ReadLine();


Console.Write($"digite sua senha: ");
int senha = int.Parse (Console.ReadLine());

Console.Clear();

Console.WriteLine($"digite o serviço que deseja: ");
Console.Clear();
Console.WriteLine(@$"
---------------------------------------------------
|               informe o servico que deseja       |
| '1' cadastrar passagem                           | 
| '2' listar passagem                              | 
| '0' sair                                         |
---------------------------------------------------
");
int servico = int.Parse (Console.ReadLine());

//processamento



switch (servico)

{
    case '1':

        if (servico == 1)
        {
            Console.WriteLine($"opcao desejada cadastrar passagem");

        }
        break;

    case '2':
        if (servico == 2)
        {
            Console.WriteLine($" listar passagem");
        }

         break;

    case '0':
sair = false;
       

        break;

}


    default:
        Console.WriteLine($"opcao n encontrada ");
        break;
}


if(senha==123456)
{
    Console.WriteLine($"usuario logado");
    
}
else
{
    Console.WriteLine($"tente novamente");
    
}