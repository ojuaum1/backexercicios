// 2) Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.


Console.WriteLine($"quantos gols o time da casa fez ??");
int valor1 = int.Parse (Console.ReadLine());

Console.WriteLine($"quantos gols o time de fora fez ??");
int valor2 = int.Parse (Console.ReadLine());


if (valor1 > valor2) 
{
Console.WriteLine($"time 1 ganhou");

}

else if( valor1 < valor2)
{
Console.WriteLine($"timme 2 ganhou");

}

else
{
 Console.WriteLine($"empate");
 
}