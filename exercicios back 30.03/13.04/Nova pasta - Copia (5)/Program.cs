// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// // entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

string[] nomes = new string[10];


//recebe e armazena os nomes 
for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome: ");
    nomes[i] = Console.ReadLine();

}

//busca nome o nome 
//  for (var posicao = 0; posicao < 10; posicao++)
//  {
//      Console.ForegroundColor = ConsoleColor.Blue;
//      Console.WriteLine($"{posicao + 1}) nome: {nomes[posicao]}  ");
//      Console.ResetColor();

   
//      Console.WriteLine($"");    
//}

Console.WriteLine($"qual é o nome que deseja encontrar");
string nomedigitado = (Console.ReadLine());

// if (nomedigitado == nomes[3])
// {
//     Console.WriteLine($"nome encontrado");
    
// }
// else
// {
//     Console.WriteLine($"nome nao encontrado");
    
// }
 
if (nomes.Contains(nomedigitado))
{
    Console.WriteLine($"Nome encontrado{posi}");
    
}
else 
{
    Console.WriteLine($"Nome nao encontrado");
    
}



