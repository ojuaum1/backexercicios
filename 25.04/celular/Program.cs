// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.


using Celular;

celular novoCell = new celular();

Console.WriteLine(@$"
---------------------------------------------------
|               informe a bebida que deseja        |
| '1' ligar celular                                | 
| '2' desligar celular                             | 
| '3' enviar mensagem                              |     
| '4' fazer ligação                                |
---------------------------------------------------
");

string opção = Console.ReadLine();

switch (opção)

{
    case "1":
        novoCell.ligar();
        break;

    case "2":
        novoCell.desligar();
        break;

    case "3":
        novoCell.enviarMensagem();
        break;

    case "4":
        novoCell.fazerLigacao();
        break;

    default:
        Console.WriteLine($"digite novamente ");
        break;

        Console.Clear();
        Console.WriteLine($"fim de programa");

}

