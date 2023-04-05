// // Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
// A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
// Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.
// Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
// A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
// Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.

// entrada
Console.WriteLine(@$"
---------------------------------------------------
|               informe a bebida que deseja        |
| 'L' laranja                                      | 
| 'U' Uva                                          | 
| 'A' abacaxi com hortelã                          |
---------------------------------------------------
");

char suquinho = char.Parse(Console.ReadLine().ToUpper());

Console.WriteLine($"gostaria de acrescentar gelo ? (S) para sim (N) para não");
char gelinho = char.Parse(Console.ReadLine().ToUpper());


// declarado variavel que receberá o resultado


// processamento

switch (suquinho)

{
    case 'L':

        if (gelinho == 'S')
        {
            Console.WriteLine($"suco de laranja com gelinho hihi");

        }
        else
        {
            Console.WriteLine($"suco de laranja sem gelinho hihi");

        }
        break;

    case 'U':
        if (gelinho == 'S')
        {
            Console.WriteLine($"suco de uva com gelinho hihi");
        }

        else
        {
            Console.WriteLine($"suco de uva sem gelinho hihi");

        }
        break;

    case 'A':

        if (gelinho == 'S')
        {
            Console.WriteLine($"suco de abacaxi com gelinho hihi");

        }

        else
        {
            Console.WriteLine($"suco de abacaxi sem gelinho hihi");

        }
        break;


    default:
        Console.WriteLine($"bebida não encontrada ");
        break;

Console.Clear();
Console.WriteLine($"fim de programa");

}



