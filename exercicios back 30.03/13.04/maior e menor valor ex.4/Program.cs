// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.
float[]valores = new float[10];
for (int i = 0; i < 10; i++)
{
    Console.Write(@$"Digite o valor desejado: ");
     valores[i] = int.Parse(Console.ReadLine());
}

float maior = valores.Max();
float menor = valores.Min();

Console.WriteLine(@$"valor maior={maior}
valor menor={menor}");
