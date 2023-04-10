// 1)Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.WriteLine($"digite o dia do seu nascimento");
float dianascimento = float.Parse (Console.ReadLine());

Console.WriteLine($"digite o mês do seu nascimento");
float mesnascimento = float.Parse (Console.ReadLine());

Console.WriteLine($"digite o ano do seu nascimento");
float anonascimento = float.Parse (Console.ReadLine());


if (dianascimento >=1 && dianascimento <=31)
{
    Console.WriteLine($"está correto o dia");
}

if (mesnascimento >=1 && mesnascimento <=12)
{
    Console.WriteLine($"está correto o mes");
}

else 
{ mesnascimento <=0 }

if (anonascimento == 2013)
{
    Console.WriteLine($"está correto o ano");
}
