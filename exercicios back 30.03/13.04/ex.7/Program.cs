// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

float[] numeros = new float[15];
//recebe e armazena os nomes
for (var i = 0; i < 15; i++)
{
    Console.WriteLine($"digite os numeros: ");
    numeros[i] = float.Parse (Console.ReadLine());

}
//mostra ordem reversa
Console.WriteLine($"ordem reversa");
Array.Reverse(numeros);
foreach (float item in numeros)
{
    Console.WriteLine($"{item}");
    
}