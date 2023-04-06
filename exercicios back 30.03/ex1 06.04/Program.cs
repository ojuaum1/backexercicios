// faça um programa que peça uma nota, entre zero e dez. mostre uma mensagem caso o valor seja invaalido e continue pedindo até que o usario informe um valor valido

bool notacerta = false;

do
{
Console.WriteLine($"digite a nota entre 0 e 10 ?");
    int nota = int.Parse (Console.ReadLine());

if (nota >= 0 && nota <=10)
    {
        notacerta = true;
    }
}
while (notacerta == false);
Console.WriteLine($"fim de programa");
